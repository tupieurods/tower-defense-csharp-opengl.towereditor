using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using GameCoClassLibrary.Enums;
using GameCoClassLibrary.Structures;
using TowerEditorApp.Properties;

namespace TowerEditorApp
{
  public partial class MainForm : Form
  {

    /// <summary>
    /// Tower configuration
    /// </summary>
    private TowerParam TowerConfig;
    /// <summary>
    /// Current upgrading level
    /// </summary>
    private int CurrentUpLevel = -1;
    /// <summary>
    /// True: Parameter was changed by user, needs saving
    /// False: Parametr was changed by program, doesn't need saving
    /// </summary>
    private bool RealChange = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    #region Upgrade type switching
    //need some testing, UpgradingTypePostswitching method created as DRY on CodeReview
    /// <summary>
    /// Actions after succesfull upgrading type switching.
    /// </summary>
    /// <param name="upType">Up type.</param>
    /// <param name="unlimitedUpToConfig">Sets upgrading type</param>
    /// <param name="GBUnlimited">Sets Unlimited Group Box enabled or not</param>
    /// <param name="GBLimited">Sets Limited Group Box enabled or not.</param>
    private void UpgradingTypePostswitching(UpgradeType upType, bool unlimitedUpToConfig, bool GBUnlimited, bool GBLimited)
    {
      GBUpType.Tag = (int)upType;
      TowerConfig.UpgradeParams.RemoveRange(1, TowerConfig.UpgradeParams.Count - 1);
      GBLimitedUp.Text = Resources.LimitedUpgradeDefaultTitle;
      CurrentUpLevel = -1;
      TowerConfig.UnlimitedUp = unlimitedUpToConfig;
      GBUnlimitedUp.Enabled = GBUnlimited;
      GBLimitedUp.Enabled = GBLimited;
    }

    /// <summary>
    /// Switching to the unlimited type of tower upgrading
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void RBUnlimitedUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Switching from another upgrading type
      {
        if ((int)GBUpType.Tag != 0)
        {
          if (MessageBox.Show(Resources.Update_type_changing, Resources.WarningCaption, MessageBoxButtons.YesNo) != DialogResult.Yes)//May be user missclicked, check this
          {
            switch ((UpgradeType)Convert.ToInt32(GBUpType.Tag))
            {
              case UpgradeType.Limited:
                RBLimitedUp.Checked = true;
                break;
              case UpgradeType.NoUp:
                RBNoUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      UpgradingTypePostswitching(UpgradeType.Unlimited, true, true, false);
      AddNewUpLevel();
      UnlimitedShow();
    }

    /// <summary>
    /// Switching to the limited type of tower upgrading
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void RBLimitedUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Switching from another upgrading type
      {
        if ((int)GBUpType.Tag != 1)
        {
          if (MessageBox.Show(Resources.Update_type_changing, Resources.WarningCaption, MessageBoxButtons.YesNo) != DialogResult.Yes)//May be user missclicked, check this
          {
            switch ((UpgradeType)Convert.ToInt32(GBUpType.Tag))
            {
              case UpgradeType.Unlimited:
                RBUnlimitedUp.Checked = true;
                break;
              case UpgradeType.NoUp:
                RBNoUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      UpgradingTypePostswitching(UpgradeType.Limited, false, false, true);
    }

    /// <summary>
    /// Switching to the type of tower without any upgrade
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void RBNoUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Switching from another upgrading type
      {
        if ((int)GBUpType.Tag != 2)
        {
          if (MessageBox.Show(Resources.Update_type_changing, Resources.WarningCaption, MessageBoxButtons.YesNo) != DialogResult.Yes)//May be user missclicked, check this
          {
            switch ((UpgradeType)Convert.ToInt32(GBUpType.Tag))
            {
              case UpgradeType.Unlimited:
                RBUnlimitedUp.Checked = true;
                break;
              case UpgradeType.Limited:
                RBLimitedUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      UpgradingTypePostswitching(UpgradeType.NoUp, false, false, false);
    }
    #endregion

    #region Show upgrading settings
    /// <summary>
    /// Unlimited upgrading showing
    /// </summary>
    public void UnlimitedShow()
    {
      if (TowerConfig.UpgradeParams.Count == 1)
      {
        MessageBox.Show("Wrong \"UnlimitedShow()\" method  using");
        return;
      }
      mTBuCost.Text = TowerConfig.UpgradeParams[1].Cost.ToString(CultureInfo.InvariantCulture);
      mTBuDamage.Text = TowerConfig.UpgradeParams[1].Damage.ToString(CultureInfo.InvariantCulture);
      mTBuRadius.Text = TowerConfig.UpgradeParams[1].AttackRadius.ToString(CultureInfo.InvariantCulture);
      mTBuCooldown.Text = TowerConfig.UpgradeParams[1].Cooldown.ToString(CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Limited upgrading showing
    /// </summary>
    /// <param name="ShowLevel">Number of level of upgrade</param>
    public void LimitedShow(int ShowLevel)
    {
      if (ShowLevel >= TowerConfig.UpgradeParams.Count)
        return;
      mTBlCost.Text = TowerConfig.UpgradeParams[ShowLevel].Cost.ToString(CultureInfo.InvariantCulture);
      //MessageBox.Show(ShowLevel.ToString()+"\n"+TowerConfig.UpgradeParams[ShowLevel].Cost.ToString());
      mTBlDamage.Text = TowerConfig.UpgradeParams[ShowLevel].Damage.ToString(CultureInfo.InvariantCulture);
      mTBlRadius.Text = TowerConfig.UpgradeParams[ShowLevel].AttackRadius.ToString(CultureInfo.InvariantCulture);
      mTBlCooldown.Text = TowerConfig.UpgradeParams[ShowLevel].Cooldown.ToString(CultureInfo.InvariantCulture);
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString(CultureInfo.InvariantCulture) + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString(CultureInfo.InvariantCulture);
    }
    #endregion

    #region Text settings checking
    /// <summary>
    /// Critical strike multiplie checking
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
    private void TBCritMultiple_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar == '.') &&
            ((TBCritMultiple.Text.Length == 0) || (TBCritMultiple.MaxLength - TBCritMultiple.Text.Length == 1) || (TBCritMultiple.Text.IndexOf(".", StringComparison.Ordinal) != -1)))
      {
        if (!(Char.IsDigit(e.KeyChar)) || (e.KeyChar != (char)Keys.Back))
        {
          e.Handled = true;
        }
      }
    }

    /// <summary>
    /// Critical strike multiplie checking and setting
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void TBCritMultiple_TextChanged(object sender, EventArgs e)
    {
      if ((TBCritMultiple.Text == string.Empty) || (!RealChange))
        return;
      sMainTowerParam Tmp = TowerConfig.UpgradeParams[GetIndexByName(TBCritMultiple.Name)];
      object TmpValue = Tmp.CritMultiple;
      ValidateAndChange(TBCritMultiple.Text, ref TmpValue);
      Tmp.CritMultiple = (double)TmpValue;
      TowerConfig.UpgradeParams[GetIndexByName(TBCritMultiple.Name)] = Tmp;
    }

    /// <summary>
    /// Masked text boxes changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void maskedTextBoxChanged(object sender, EventArgs e)
    {
      if ((sender as MaskedTextBox) == null)
      {
        MessageBox.Show("BAD BAD BAD programmer again! The method is used incorrectly.");
        return;
      }
      if (((sender as MaskedTextBox).Text == string.Empty) || (!RealChange))
        return;
      int index = GetIndexByName((sender as MaskedTextBox).Name);
      if (index == -1)
        return;
      #region Value changing
      sMainTowerParam Tmp = TowerConfig.UpgradeParams[index];
      object TmpValue;
      switch ((sender as MaskedTextBox).Name)
      {
        #region Tower Cost(and for upgrading too)
        case "mTBCost":
        case "mTBlCost":
        case "mTBuCost":
          TmpValue = Tmp.Cost;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Cost = (int)TmpValue;
          break;
        #endregion
        #region Damdage(and for upgrading too)
        case "mTBDamage":
        case "mTBlDamage":
        case "mTBuDamage":
          TmpValue = Tmp.Damage;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Damage = (int)TmpValue;
          break;
        #endregion
        #region Attack radius(and for upgrading too)
        case "mTBRadius":
        case "mTBlRadius":
        case "mTBuRadius":
          TmpValue = Tmp.AttackRadius;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.AttackRadius = (int)TmpValue;
          break;
        #endregion
        #region Number of targets
        case "mTBNumberOfTargets":
          /*case "mTBlNumberOfTargets":
           case "mTBuNumberOfTargets":*/
          TmpValue = Tmp.NumberOfTargets;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.NumberOfTargets = (int)TmpValue;
          break;
        #endregion
        #region Critical chance
        case "mTBCritChance":
          /*case "mTBlCritChance":
           case "mTBuCritChance":*/
          TmpValue = Tmp.CritChance;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          if (((byte)TmpValue > 0) && ((byte)TmpValue < 100))
            Tmp.CritChance = (byte)TmpValue;
          break;
        #endregion
        #region Attack Cooldown
        case "mTBCooldown":
        case "mTBlCooldown":
        case "mTBuCooldown":
          TmpValue = Tmp.Cooldown;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Cooldown = (int)TmpValue;
          break;
        #endregion
      }
      TowerConfig.UpgradeParams[index] = Tmp;
      #endregion
    }

    /// <summary>
    /// Validates the value and if valid change.
    /// </summary>
    /// <param name="TextForValidate">The text for validate.</param>
    /// <param name="ValueToChange">The value to change.</param>
    private void ValidateAndChange(string TextForValidate, ref object ValueToChange)
    {
      Type ValueType = ValueToChange.GetType();
      if (ValueType == typeof(int))
      {
        int Tmp = Convert.ToInt32(ValueToChange);
        Int32.TryParse(TextForValidate, out Tmp);
        ValueToChange = Tmp;
      }
      else if (ValueType == typeof(byte))
      {
        byte Tmp = Convert.ToByte(ValueToChange);
        byte.TryParse(TextForValidate, out Tmp);
        ValueToChange = Tmp;
      }
      else if (ValueType == typeof(double))
      {
        double Tmp = Convert.ToDouble(ValueToChange);
        double.TryParse(TextForValidate.Replace('.',
          Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)), out Tmp);
        ValueToChange = Tmp;
      }
      else
        MessageBox.Show("Method \"ValidateAndChange\" used wrong!");
    }
    #endregion

    #region  RadioButtons and CheckBoxes changing
    /// <summary>
    /// Attack modificator changing
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void RBNoEffect_Click(object sender, EventArgs e)
    {
      TowerConfig.Modificator = (eModificatorName)Convert.ToInt32((sender as RadioButton).Tag);
    }

    /// <summary>
    /// True Sight parametr changing
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void CBTrueSight_CheckedChanged(object sender, EventArgs e)
    {
      if (!RealChange)
        return;
      TowerConfig.TrueSight = CBTrueSight.Checked;
    }

    /// <summary>
    /// Tower type changing
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void RBSimpleTower_Click(object sender, EventArgs e)
    {
      TowerConfig.TowerType = (eTowerType)Convert.ToInt32((sender as RadioButton).Tag);
    }

    /// <summary>
    /// Critical strike parametr changing
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void CBEnableCrit_CheckedChanged(object sender, EventArgs e)
    {
      if (!RealChange)
        return;
      PCriticalStrikeSettings.Enabled = CBEnableCrit.Checked;
      if (!CBEnableCrit.Checked)
      {
        sMainTowerParam Tmp = TowerConfig.UpgradeParams[0];
        Tmp.CritChance = 0;
        Tmp.CritMultiple = 0;
        TowerConfig.UpgradeParams[0] = Tmp;
        TBCritMultiple.Text = "0";
        mTBCritChance.Text = "0";
      }
    }
    #endregion

    #region Working with limited upgrading
    /// <summary>
    /// Adds new limited upgrade
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BlAddUp_Click(object sender, EventArgs e)
    {
      if (CurrentUpLevel == -1)
        CurrentUpLevel = 0;
      AddNewUpLevel(TowerConfig.UpgradeParams[0].AttackRadius, 45, ++CurrentUpLevel);
      LimitedShow(CurrentUpLevel);
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString(CultureInfo.InvariantCulture) + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString(CultureInfo.InvariantCulture);
      if (TowerConfig.UpgradeParams.Count == 2)
      {
        BlRemoveUp.Enabled = true;
      }
      if (TowerConfig.UpgradeParams.Count == 3)
      {
        BlPreviousUp.Enabled = true;
        BlNextUp.Enabled = true;
      }
    }

    /// <summary>
    /// Removes current limited upgrade
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BlRemoveUp_Click(object sender, EventArgs e)
    {
      TowerConfig.UpgradeParams.RemoveAt(CurrentUpLevel--);
      if ((CurrentUpLevel == 0) && (TowerConfig.UpgradeParams.Count != 1))
        CurrentUpLevel = 1;
      LimitedShow(CurrentUpLevel);
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString(CultureInfo.InvariantCulture) + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString(CultureInfo.InvariantCulture);
      if (TowerConfig.UpgradeParams.Count == 1)
      {
        BlRemoveUp.Enabled = false;
        CurrentUpLevel = -1;
      }
      if (TowerConfig.UpgradeParams.Count == 2)
      {
        BlPreviousUp.Enabled = false;
        BlNextUp.Enabled = false;
      }
    }

    /// <summary>
    /// Going to Next limited upgrade
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BlNextUp_Click(object sender, EventArgs e)
    {
      CurrentUpLevel++;
      if (CurrentUpLevel == TowerConfig.UpgradeParams.Count)
      {
        CurrentUpLevel = 1;
      }
      LimitedShow(CurrentUpLevel);
    }

    /// <summary>
    /// Going to Previous limited upgrade
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BlPreviousUp_Click(object sender, EventArgs e)
    {
      CurrentUpLevel--;
      if (CurrentUpLevel == 0)
      {
        CurrentUpLevel = TowerConfig.UpgradeParams.Count - 1;
      }
      LimitedShow(CurrentUpLevel);
    }
    #endregion

    #region Pictures loading
    /// <summary>
    /// Loads tower icon for shop
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BLoadTowerIcon_Click(object sender, EventArgs e)
    {
      OFDialog.Filter = "Bitmap|*.bmp|Png picture|*.png";
      if (OFDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          TowerConfig.Icon = new Bitmap(OFDialog.FileName);
          PBTowerIcon.Image = TowerConfig.Icon;
        }
        catch (Exception exp)
        {
          MessageBox.Show("Picture loading error: " + exp.Message);
        }
      }
    }

    /// <summary>
    /// Loads tower picture for rendering on the map
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BLoadTowerBitmap_Click(object sender, EventArgs e)
    {
      OFDialog.Filter = "Bitmap|*.bmp|Png picture|*.png";
      if (OFDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          sMainTowerParam Tmp = TowerConfig.UpgradeParams[0];
          Tmp.Picture = new Bitmap(OFDialog.FileName);
          TowerConfig.UpgradeParams[0] = Tmp;
          PBTowerBitmap.Size = TowerConfig.UpgradeParams[0].Picture.Size;
          PBTowerBitmap.Image = TowerConfig.UpgradeParams[0].Picture;
        }
        catch (Exception exp)
        {
          MessageBox.Show("Picture loading error: " + exp.Message);
        }
      }
    }
    #endregion

    #region Color selection for missle rendering

    /// <summary>
    /// Pen color selection
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BSelectPenColor_Click(object sender, EventArgs e)
    {
      if (CDSelect.ShowDialog() == DialogResult.OK)
      {
        TowerConfig.MisslePenColor = CDSelect.Color;
        Bitmap Tmp = new Bitmap(PBMisslePenColor.Width, PBMisslePenColor.Height);
        Graphics Canva = Graphics.FromImage(Tmp);
        Canva.FillRectangle(new SolidBrush(TowerConfig.MisslePenColor), new Rectangle(0, 0, Tmp.Width, Tmp.Height));
        PBMisslePenColor.Image = Tmp;
      }
    }

    /// <summary>
    /// Brush color selection
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BSelectBrushColor_Click(object sender, EventArgs e)
    {
      if (CDSelect.ShowDialog() == DialogResult.OK)
      {
        TowerConfig.MissleBrushColor = CDSelect.Color;
        Bitmap Tmp = new Bitmap(PBMissleBrushColor.Width, PBMissleBrushColor.Height);
        Graphics Canva = Graphics.FromImage(Tmp);
        Canva.FillRectangle(new SolidBrush(TowerConfig.MissleBrushColor), new Rectangle(0, 0, Tmp.Width, Tmp.Height));
        PBMissleBrushColor.Image = Tmp;
      }
    }
    #endregion

    #region Save/Load
    /// <summary>
    /// Tower configuration saving
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BSave_Click(object sender, EventArgs e)
    {
      SFDialog.FileName = "*.tdtc";
      SFDialog.Filter = "Tower configuration|*.tdtc";
      if (SFDialog.ShowDialog() == DialogResult.OK)
      {
        using (FileStream TowerConfSaveStream = new FileStream(SFDialog.FileName, FileMode.Create, FileAccess.Write))
        {
          try
          {
            IFormatter Formatter = new BinaryFormatter();
            Formatter.Serialize(TowerConfSaveStream, TowerConfig);
          }
          catch (Exception Exc)
          {
            MessageBox.Show("Tower configuration saving error: \n" + Exc.Message);
          }
        }
      }
    }

    /// <summary>
    /// Tower configuration loading
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BLoad_Click(object sender, EventArgs e)
    {
      OFDialog.FileName = "*.tdtc";
      OFDialog.Filter = "Tower configuration|*.tdtc";
      if (OFDialog.ShowDialog() == DialogResult.OK)
      {
        using (FileStream TowerConfLoadStream = new FileStream(OFDialog.FileName, FileMode.Open, FileAccess.Read))
        {
          try
          {
            IFormatter Formatter = new BinaryFormatter();
            TowerConfig = (TowerParam)Formatter.Deserialize(TowerConfLoadStream);
            SetParams();
          }
          catch (Exception Exc)
          {
            MessageBox.Show("Tower configuration loading error: \n" + Exc.Message);
          }
        }
      }
    }
    #endregion

    /// <summary>
    /// New tower creating
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BNewTowerConf_Click(object sender, EventArgs e)
    {
      TowerConfig = new TowerParam();
      SetParams();
    }

    /// <summary>
    /// Sets the tower parametrs on creating/loading tower configuration
    /// </summary>
    public void SetParams()
    {
      GBTowerConf.Enabled = true;
      BSave.Enabled = true;

      RealChange = false;
      #region Text fields
      //Critical strike
      mTBCritChance.Text = TowerConfig.UpgradeParams[0].CritChance.ToString(CultureInfo.InvariantCulture);
      TBCritMultiple.Text = TowerConfig.UpgradeParams[0].CritMultiple.ToString(CultureInfo.InvariantCulture);
      //cost
      mTBCost.Text = TowerConfig.UpgradeParams[0].Cost.ToString(CultureInfo.InvariantCulture);
      mTBlCost.Text = "40";
      mTBuCost.Text = "40";
      //damadge
      mTBDamage.Text = TowerConfig.UpgradeParams[0].Damage.ToString(CultureInfo.InvariantCulture);
      mTBlDamage.Text = "50";
      mTBuDamage.Text = "50";
      //cooldown
      mTBCooldown.Text = TowerConfig.UpgradeParams[0].Cooldown.ToString(CultureInfo.InvariantCulture);
      mTBlCooldown.Text = "45";
      mTBuCooldown.Text = "0";
      //radius
      mTBRadius.Text = TowerConfig.UpgradeParams[0].AttackRadius.ToString(CultureInfo.InvariantCulture);
      mTBlRadius.Text = "100";
      mTBuRadius.Text = "0";
      //NumberofTargets
      mTBNumberOfTargets.Text = TowerConfig.UpgradeParams[0].NumberOfTargets.ToString(CultureInfo.InvariantCulture);
      #endregion

      #region Checkboxs and RadioButtons
      switch (TowerConfig.Modificator)//Attack modificator
      {
        case eModificatorName.NoEffect:
          RBNoEffect.Checked = true;
          break;
        case eModificatorName.Freeze:
          RBFreezeEffect.Checked = true;
          break;
        case eModificatorName.Burn:
          RBBurnEffect.Checked = true;
          break;
        case eModificatorName.Posion:
          RBPosionEffect.Checked = true;
          break;
      }
      CurrentUpLevel = -1;
      GBLimitedUp.Enabled = false;
      GBUnlimitedUp.Enabled = false;
      if (TowerConfig.UnlimitedUp)//Upgrade type - Unlimited
      {
        RBUnlimitedUp.Checked = true;
        GBUnlimitedUp.Enabled = true;
        GBUpType.Tag = 0;
        UnlimitedShow();
      }
      else if (TowerConfig.UpgradeParams.Count == 1)//No upgrade
      {
        RBNoUp.Checked = true;
        GBUpType.Tag = 2;
      }
      else//Upgrade type - Limited
      {
        RBLimitedUp.Checked = true;
        GBLimitedUp.Enabled = true;
        GBUpType.Tag = 1;
        if (TowerConfig.UpgradeParams.Count > 2)
        {
          BlNextUp.Enabled = true;
          BlPreviousUp.Enabled = true;
          BlRemoveUp.Enabled = true;
        }
        LimitedShow(CurrentUpLevel = 1);
      }
      switch (TowerConfig.TowerType)//Tower type
      {
        case eTowerType.Simple:
          RBSimpleTower.Checked = true;
          break;
        case eTowerType.Splash:
          RBSplashTower.Checked = true;
          break;
      }
      CBEnableCrit.Checked = TowerConfig.UpgradeParams[0].CritMultiple >= 0.001;//Critical strike
      PCriticalStrikeSettings.Enabled = CBEnableCrit.Checked;
      CBTrueSight.Checked = TowerConfig.TrueSight;
      #endregion

      #region Pictures
      PBTowerBitmap.Image = TowerConfig.UpgradeParams[0].Picture;
      PBTowerIcon.Image = TowerConfig.Icon;
      //Pen color
      Bitmap Tmp = new Bitmap(PBMisslePenColor.Width, PBMisslePenColor.Height);
      Graphics Canva = Graphics.FromImage(Tmp);
      Canva.FillRectangle(new SolidBrush(TowerConfig.MisslePenColor),
        new Rectangle(0, 0, Tmp.Width, Tmp.Height));
      PBMisslePenColor.Image = Tmp;
      //brush color
      Tmp = new Bitmap(PBMissleBrushColor.Width, PBMissleBrushColor.Height);
      Canva = Graphics.FromImage(Tmp);
      Canva.FillRectangle(new SolidBrush(TowerConfig.MissleBrushColor),
        new Rectangle(0, 0, Tmp.Width, Tmp.Height));
      PBMissleBrushColor.Image = Tmp;
      #endregion

      RealChange = true;
    }

    /// <summary>
    /// Gets current index of tower level
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    private int GetIndexByName(string name)
    {
      if (name.IndexOf("mTBl", StringComparison.Ordinal) != -1)//LimitedUpgrade
        return CurrentUpLevel;
      else if (name.IndexOf("mTBu", StringComparison.Ordinal) != -1)//UnlimitedUpgrade
        return 1;
      else//Main parametrs
        return 0;
    }

    /// <summary>
    /// Adds the new up level.
    /// </summary>
    /// <param name="Radius">The radius.</param>
    /// <param name="Cooldown">The cooldown.</param>
    /// <param name="InsertPos">The insert pos.</param>
    public void AddNewUpLevel(int Radius = 0, int Cooldown = 0, int InsertPos = 1)
    {
      sMainTowerParam AddValue = sMainTowerParam.CreateDefault();
      AddValue.AttackRadius = Radius;
      AddValue.Cooldown = Cooldown;
      AddValue.Cost = TowerConfig.UpgradeParams[0].Cost;//by deafult
      AddValue.Damage = TowerConfig.UpgradeParams[0].Damage;
      #region Currently it's don't change with level, wrote for future
      AddValue.CritChance = TowerConfig.UpgradeParams[0].CritChance;
      AddValue.CritMultiple = TowerConfig.UpgradeParams[0].CritMultiple;
      AddValue.NumberOfTargets = TowerConfig.UpgradeParams[0].NumberOfTargets;
      #endregion
      TowerConfig.UpgradeParams.Insert(InsertPos, AddValue);
    }

    /// <summary>
    /// Shows centered pictures.
    /// </summary>
    /// <param name="ShowingType">
    ///1-Icon only
    ///2-Picture only
    ///3-Icon and Picture
    /// </param>
    [Obsolete("Currently is useless")]
    private void ShowPictures(byte ShowingType)
    {
      switch (ShowingType)
      {
        case 3:
          {
            Bitmap Tmp = new Bitmap(PBTowerIcon.Width, PBTowerIcon.Height);
            Graphics Canva = Graphics.FromImage(Tmp);
            Canva.DrawImage(TowerConfig.Icon, PBTowerIcon.Width / 2 - TowerConfig.Icon.Width / 2,
              PBTowerIcon.Width / 2 - TowerConfig.Icon.Width / 2, TowerConfig.Icon.Width, TowerConfig.Icon.Height);
            PBTowerIcon.Image = Tmp;

            Tmp = new Bitmap(TowerConfig.UpgradeParams[0].Picture);
            PBTowerBitmap.Size = Tmp.Size;
            PBTowerBitmap.Image = Tmp;
          };
          break;
        case 1:
          {
            Bitmap Tmp = new Bitmap(PBTowerIcon.Width, PBTowerIcon.Height);
            Graphics Canva = Graphics.FromImage(Tmp);
            Canva.DrawImage(TowerConfig.Icon, PBTowerIcon.Width / 2 - TowerConfig.Icon.Width / 2,
              PBTowerIcon.Width / 2 - TowerConfig.Icon.Width / 2, TowerConfig.Icon.Width, TowerConfig.Icon.Height);
            PBTowerIcon.Image = Tmp;
          };
          break;
        case 2:
          {
            Bitmap Tmp = TowerConfig.UpgradeParams[0].Picture;
            PBTowerBitmap.Size = Tmp.Size;
            PBTowerBitmap.Image = Tmp;
          };
          break;
      }
    }
  }
}
