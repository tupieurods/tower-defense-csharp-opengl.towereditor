using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GameCoClassLibrary;

namespace TowerEditorApp
{
  public partial class MainForm : Form
  {

    private TowerParam TowerConfig;
    private int CurrentUpLevel = -1;
    private bool RealChange = true;

    public MainForm()
    {
      InitializeComponent();
    }

    #region Переключение типов улучшений
    //В будущем переделать переключение, убрать дублирование кода
    private void RBUnlimitedUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Если переключились с другого типа обновления и там уже что-то добавили
      {
        if ((int)GBUpType.Tag != 0)
        {
          if (MessageBox.Show("Do you really want change update type?", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)//Если ошибочно нажали
          {
            switch ((int)GBUpType.Tag)
            {
              case 1:
                RBLimitedUp.Checked = true;
                break;
              case 2:
                RBNoUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      GBUpType.Tag = 0;//Какой тип обновления выбран
      TowerConfig.UpgradeParams.RemoveRange(1, TowerConfig.UpgradeParams.Count - 1);//Удалили все старые обновления
      //если мы дошли до сюда, значит пользователь смирился с потерей своих наработок
      GBLimitedUp.Text = "Limited upgrade 0/0";
      AddNewUpLevel();
      UnlimitedShow();
      CurrentUpLevel = -1;
      TowerConfig.UnlimitedUp = true;
      GBUnlimitedUp.Enabled = true;
      GBLimitedUp.Enabled = false;//Чтобы не возникло путаницы
    }

    private void RBLimitedUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Если переключились с другого типа обновления и там уже что-то добавили
      {
        if ((int)GBUpType.Tag != 1)
        {
          if (MessageBox.Show("Do you really want change update type?", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)//Если ошибочно нажали
          {
            switch ((int)GBUpType.Tag)
            {
              case 0:
                RBUnlimitedUp.Checked = true;
                break;
              case 2:
                RBNoUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      GBUpType.Tag = 1;//Какой тип обновления выбран
      TowerConfig.UpgradeParams.RemoveRange(1, TowerConfig.UpgradeParams.Count - 1);//Удалили все старые обновления
      //если мы дошли до сюда, значит пользователь смирился с потерей своих наработок
      GBLimitedUp.Text = "Limited upgrade 0/0";
      CurrentUpLevel = -1;
      TowerConfig.UnlimitedUp = false;
      GBUnlimitedUp.Enabled = false;
      GBLimitedUp.Enabled = true;
    }

    private void RBNoUp_Click(object sender, EventArgs e)
    {
      if (TowerConfig.UpgradeParams.Count > 1)//Если переключились с другого типа обновления и там уже что-то добавили
      {
        if ((int)GBUpType.Tag != 2)
        {
          if (MessageBox.Show("Do you really want change update type?", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)//Если ошибочно нажали
          {
            switch ((int)GBUpType.Tag)
            {
              case 0:
                RBUnlimitedUp.Checked = true;
                break;
              case 1:
                RBLimitedUp.Checked = true;
                break;
            }
            return;
          }
        }
        else
          return;
      }
      GBUpType.Tag = 2;
      TowerConfig.UpgradeParams.RemoveRange(1, TowerConfig.UpgradeParams.Count - 1);//Удалили все старые обновления
      //если мы дошли до сюда, значит пользователь смирился с потерей своих наработок
      GBLimitedUp.Text = "Limited upgrade 0/0";
      CurrentUpLevel = -1;
      TowerConfig.UnlimitedUp = false;
      GBUnlimitedUp.Enabled = false;
      GBLimitedUp.Enabled = false;
    }
    #endregion

    #region Показ параметров обновления
    public void UnlimitedShow()
    {
      if (TowerConfig.UpgradeParams.Count == 1)
      {
        MessageBox.Show("Wrong \"UnlimitedShow()\" method  using");
        return;
      }
      mTBuCost.Text = TowerConfig.UpgradeParams[1].Cost.ToString();
      mTBuDamage.Text = TowerConfig.UpgradeParams[1].Damage.ToString();
      mTBuRadius.Text = TowerConfig.UpgradeParams[1].AttackRadius.ToString();
      mTBuCooldown.Text = TowerConfig.UpgradeParams[1].Cooldown.ToString();
    }

    public void LimitedShow(int ShowLevel)
    {
      if (ShowLevel >= TowerConfig.UpgradeParams.Count)
        return;
      mTBlCost.Text = TowerConfig.UpgradeParams[ShowLevel].Cost.ToString();
      //MessageBox.Show(ShowLevel.ToString()+"\n"+TowerConfig.UpgradeParams[ShowLevel].Cost.ToString());
      mTBlDamage.Text = TowerConfig.UpgradeParams[ShowLevel].Damage.ToString();
      mTBlRadius.Text = TowerConfig.UpgradeParams[ShowLevel].AttackRadius.ToString();
      mTBlCooldown.Text = TowerConfig.UpgradeParams[ShowLevel].Cooldown.ToString();
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString() + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString();
    }
    #endregion

    #region Ввод текстовых данных
    //Фильтрация ввода в TextBox со значением множителя CriticalStrike
    private void TBCritMultiple_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar == '.') &&
            ((TBCritMultiple.Text.Length == 0) || (TBCritMultiple.MaxLength - TBCritMultiple.Text.Length == 1) || (TBCritMultiple.Text.IndexOf(".") != -1)))
      {
        if (!(Char.IsDigit(e.KeyChar)) || (e.KeyChar != (char)Keys.Back))
        {
          e.Handled = true;
        }
      }
    }

    //Проверка множителя критического удара
    private void TBCritMultiple_TextChanged(object sender, EventArgs e)
    {
      if (((sender as TextBox).Text == string.Empty) || (!RealChange))
        return;
      sMainTowerParam Tmp = TowerConfig.UpgradeParams[GetIndexByName((sender as TextBox).Name)];
      object TmpValue = Tmp.CritMultiple;
      ValidateAndChange((sender as TextBox).Text, ref TmpValue);
      Tmp.CritMultiple = (double)TmpValue;
      TowerConfig.UpgradeParams[GetIndexByName((sender as TextBox).Name)] = Tmp;
    }

    //Изменение текста в TextBox'ах, задающих параметры
    private void maskedTextBoxChanged(object sender, EventArgs e)
    {
      if ((sender as MaskedTextBox) == null)
      {
        MessageBox.Show("BAD BAD BAD programmer again! Used metod incorrect. KILL HIM");
        return;
      }
      if (((sender as MaskedTextBox).Text == string.Empty) || (!RealChange))
        return;
      int index = GetIndexByName((sender as MaskedTextBox).Name);
      if (index == -1)
        return;
      #region Изменение значения
      sMainTowerParam Tmp = TowerConfig.UpgradeParams[index];
      object TmpValue;
      switch ((sender as MaskedTextBox).Name)
      {
        #region Стоимость
        case "mTBCost":
        case "mTBlCost":
        case "mTBuCost":
          TmpValue = Tmp.Cost;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Cost = (int)TmpValue;
          break;
        #endregion
        #region Урон
        case "mTBDamage":
        case "mTBlDamage":
        case "mTBuDamage":
          TmpValue = Tmp.Damage;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Damage = (int)TmpValue;
          break;
        #endregion
        #region Радиус атаки
        case "mTBRadius":
        case "mTBlRadius":
        case "mTBuRadius":
          TmpValue = Tmp.AttackRadius;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.AttackRadius = (int)TmpValue;
          break;
        #endregion
        #region Число целей
        case "mTBNumberOfTargets":
          /*case "mTBlNumberOfTargets":
           case "mTBuNumberOfTargets":*/
          TmpValue = Tmp.NumberOfTargets;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.NumberOfTargets = (int)TmpValue;
          break;
        #endregion
        #region Шанс на критическую атаку
        case "mTBCritChance":
          /*case "mTBlCritChance":
           case "mTBuCritChance":*/
          TmpValue = Tmp.CritChance;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          if (((byte)TmpValue > 0) && ((byte)TmpValue < 100))
            Tmp.CritChance = (byte)TmpValue;
          break;
        #endregion
        #region Период до новой атаки
        case "mTBCooldown":
        case "mTBlCooldown":
        case "mTBuCooldown":
          TmpValue = Tmp.Cooldown;
          ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
          Tmp.Cooldown = (int)TmpValue;
          //MessageBox.Show(index.ToString() + "\n" + TowerConfig.UpgradeParams.Count.ToString());
          break;
        #endregion
      }
      TowerConfig.UpgradeParams[index] = Tmp;
      #endregion
    }

    //Проверить значение и при успешном результате изменить
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
          Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)), out Tmp);
        ValueToChange = Tmp;
      }
      else
        MessageBox.Show("Method \"ValidateAndChange\" used wrong!");
    }
    #endregion

    #region Изменение состояния RadioButton'ов и CheckBox'ов
    //Установление эффекта
    private void RBNoEffect_Click(object sender, EventArgs e)
    {
      TowerConfig.Modificator = (eModificatorName)Convert.ToInt32((sender as RadioButton).Tag);
    }

    //Установление TrueSight свойства
    private void CBTrueSight_CheckedChanged(object sender, EventArgs e)
    {
      if (!RealChange)
        return;
      TowerConfig.TrueSight = CBTrueSight.Checked;
    }

    //Выбор типа башни
    private void RBSimpleTower_Click(object sender, EventArgs e)
    {
      TowerConfig.TowerType = (eTowerType)Convert.ToInt32((sender as RadioButton).Tag);
    }

    //On/Off критического удара
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

    #region Работа с Limited обновлением
    //Добавление нового Limited уровня обновления
    //Не делаем проверку на то можно добавить или нет, т.к логикой Enabled невозможно попасть сюда в некорректном состоянии
    private void BlAddUp_Click(object sender, EventArgs e)
    {
      if (CurrentUpLevel == -1)
        CurrentUpLevel = 0;
      AddNewUpLevel(TowerConfig.UpgradeParams[0].AttackRadius, 45, ++CurrentUpLevel);
      LimitedShow(CurrentUpLevel);
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString() + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString();
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

    //Удаление Limited up уровня
    private void BlRemoveUp_Click(object sender, EventArgs e)
    {
      TowerConfig.UpgradeParams.RemoveAt(CurrentUpLevel--);
      if ((CurrentUpLevel == 0) && (TowerConfig.UpgradeParams.Count != 1))
        CurrentUpLevel = 1;
      LimitedShow(CurrentUpLevel);
      GBLimitedUp.Text = "Limited upgrade " + CurrentUpLevel.ToString() + "/" + (TowerConfig.UpgradeParams.Count - 1).ToString();
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

    //Переключение Limited up вперёд
    private void BlNextUp_Click(object sender, EventArgs e)
    {
      CurrentUpLevel++;
      if (CurrentUpLevel == TowerConfig.UpgradeParams.Count)
      {
        CurrentUpLevel = 1;
      }
      LimitedShow(CurrentUpLevel);
    }

    //Переключение Limited up назад
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

    #region Загрузка изображения башни
    //загрузка иконки башни для магазина
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
          MessageBox.Show("Ошибка при загрузке изображения: " + exp.Message);
        }
      }
    }

    //Загрузка изображения башни на карте
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
          MessageBox.Show("Ошибка при загрузке изображения: " + exp.Message);
        }
      }
    }
    #endregion

    #region Выбор цветов для отрисовки снаряда
    //Выбор Pen цвета отрисовки снаряда
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

    //Выбор Brush цвета отрисовки снаряда
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
    //Сохранение
    private void BSave_Click(object sender, EventArgs e)
    {
      SFDialog.FileName = "*.tdtc";
      SFDialog.Filter = "Файл конфигурации башни|*.tdtc";
      if (SFDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          FileStream TowerConfSaveStream = new FileStream(SFDialog.FileName, FileMode.Create, FileAccess.Write);
          IFormatter Formatter = new BinaryFormatter();
          Formatter.Serialize(TowerConfSaveStream, TowerConfig);
          TowerConfSaveStream.Close();
        }
        catch (Exception Exc)
        {
          MessageBox.Show("Невохможно сохранить конфигурацию: \n" + Exc.Message);
        }
      }
    }

    //Загрузка
    private void BLoad_Click(object sender, EventArgs e)
    {
      OFDialog.FileName = "*.tdtc";
      OFDialog.Filter = "Файл конфигурации башни|*.tdtc";
      if (OFDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          FileStream TowerConfLoadStream = new FileStream(OFDialog.FileName, FileMode.Open, FileAccess.Read);
          IFormatter Formatter = new BinaryFormatter();
          TowerConfig = (TowerParam)Formatter.Deserialize(TowerConfLoadStream);
          TowerConfLoadStream.Close();
          SetParams();
        }
        catch (Exception Exc)
        {
          MessageBox.Show("Невохможно загрузить конфигурацию: \n" + Exc.Message);
        }
      }
    }
    #endregion

    //Создание новой башни
    private void BNewTowerConf_Click(object sender, EventArgs e)
    {
      TowerConfig = new TowerParam();
      SetParams();
    }

    //Установление параметров при загрузке/создании новой игры
    public void SetParams()
    {
      GBTowerConf.Enabled = true;
      BSave.Enabled = true;

      RealChange = false;
      #region Текстовые поля
      //Critical strike
      mTBCritChance.Text = TowerConfig.UpgradeParams[0].CritChance.ToString();
      TBCritMultiple.Text = TowerConfig.UpgradeParams[0].CritMultiple.ToString();
      //cost
      mTBCost.Text = TowerConfig.UpgradeParams[0].Cost.ToString();
      mTBlCost.Text = "40";
      mTBuCost.Text = "40";
      //damadge
      mTBDamage.Text = TowerConfig.UpgradeParams[0].Damage.ToString();
      mTBlDamage.Text = "50";
      mTBuDamage.Text = "50";
      //cooldown
      mTBCooldown.Text = TowerConfig.UpgradeParams[0].Cooldown.ToString();
      mTBlCooldown.Text = "45";
      mTBuCooldown.Text = "0";
      //radius
      mTBRadius.Text = TowerConfig.UpgradeParams[0].AttackRadius.ToString();
      mTBlRadius.Text = "100";
      mTBuRadius.Text = "0";
      //NumberofTargets
      mTBNumberOfTargets.Text = TowerConfig.UpgradeParams[0].NumberOfTargets.ToString();
      #endregion

      #region Checkboxs and RadioButtons
      switch (TowerConfig.Modificator)//Установка модификатора
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
      if (TowerConfig.UnlimitedUp)//Тип обновления - бесконечный
      {
        RBUnlimitedUp.Checked = true;
        GBUnlimitedUp.Enabled = true;
        GBUpType.Tag = 0;
        UnlimitedShow();
      }
      else if (TowerConfig.UpgradeParams.Count == 1)//Без обновления
      {
        RBNoUp.Checked = true;
        GBUpType.Tag = 2;
      }
      else//Тип обновления - ограниченный
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
      switch (TowerConfig.TowerType)//Тип башни
      {
        case eTowerType.Simple:
          RBSimpleTower.Checked = true;
          break;
        case eTowerType.Splash:
          RBSplashTower.Checked = true;
          break;
      }
      if (TowerConfig.UpgradeParams[0].CritMultiple == 0)//Проверка на критический урон
        CBEnableCrit.Checked = false;
      else
        CBEnableCrit.Checked = true;
      PCriticalStrikeSettings.Enabled = CBEnableCrit.Checked;
      CBTrueSight.Checked = TowerConfig.TrueSight;
      #endregion

      #region Pictures
      PBTowerBitmap.Image = TowerConfig.UpgradeParams[0].Picture;
      PBTowerIcon.Image = TowerConfig.Icon;
      //Сначал для Pen color
      Bitmap Tmp = new Bitmap(PBMisslePenColor.Width, PBMisslePenColor.Height);
      Graphics Canva = Graphics.FromImage(Tmp);
      Canva.FillRectangle(new SolidBrush(TowerConfig.MisslePenColor),
        new Rectangle(0, 0, Tmp.Width, Tmp.Height));
      PBMisslePenColor.Image = Tmp;
      //затем для brush color
      //Пересоздание для того, чтобы Canva указывал на разные Bitmap
      //и соответсвенно отображал нужный цвет
      Tmp = new Bitmap(PBMissleBrushColor.Width, PBMissleBrushColor.Height);
      Canva = Graphics.FromImage(Tmp);
      Canva.FillRectangle(new SolidBrush(TowerConfig.MissleBrushColor),
        new Rectangle(0, 0, Tmp.Width, Tmp.Height));
      PBMissleBrushColor.Image = Tmp;
      #endregion

      RealChange = true;
    }

    //Получение индекса для уровня башни по имени maskedTextBox'а
    private int GetIndexByName(string Name)
    {
      if (Name.IndexOf("mTBl") != -1)//Если мы попали сюда из LimitedUpgrade
        return CurrentUpLevel;
      else if (Name.IndexOf("mTBu") != -1)//из UnlimitedUpgrade
        return 1;
      else//Если это первоначальные настройки
        return 0;
    }

    //Добавление нового обновления
    //Если без параметров(т.е всё по умолчанию), то добавление unlimitedUp конфигурации
    public void AddNewUpLevel(int Radius = 0, int Cooldown = 0, int InsertPos = 1)
    {
      sMainTowerParam AddValue = sMainTowerParam.CreateDefault();
      AddValue.AttackRadius = Radius;
      AddValue.Cooldown = Cooldown;
      AddValue.Cost = TowerConfig.UpgradeParams[0].Cost;//По умолчанию стоимость для нового уровня и урон равны
      //базовым значениям
      AddValue.Damage = TowerConfig.UpgradeParams[0].Damage;
      #region Пока не изменяется с уровнем, чтобы не переписывать TTower если понадобится перепишем лишь редактор
      AddValue.CritChance = TowerConfig.UpgradeParams[0].CritChance;
      AddValue.CritMultiple = TowerConfig.UpgradeParams[0].CritMultiple;
      AddValue.NumberOfTargets = TowerConfig.UpgradeParams[0].NumberOfTargets;
      #endregion
      TowerConfig.UpgradeParams.Insert(InsertPos, AddValue);
    }

    [Obsolete("Использовалось для того чтобы центрировать изображение иконки")]
    //1-Icon only
    //2-Picture only
    //3-Icon and Picture
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
