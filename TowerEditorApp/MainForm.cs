using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GameCoClassLibrary;

namespace TowerEditorApp
{
  public partial class MainForm : Form
  {

    private sTowerParam TowerConfig;
    private int CurrentUpLevel;

    public MainForm()
    {
      InitializeComponent();
    }

    #region Переключение типов улучшений
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
      AddNewUpLevel();
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
      TowerConfig.UnlimitedUp = false;
      GBUnlimitedUp.Enabled = false;
      GBLimitedUp.Enabled = false;
    }
    #endregion

    //Добавление нового обновления
    //Если без параметров(т.е всё по умолчанию), то добавление unlimitedUp конфигурации
    public void AddNewUpLevel(int Radius = 0, int InsertPos = 1)
    {
      sMainTowerParam AddValue = sMainTowerParam.CreateDefault();
      AddValue.AttackRadius = Radius;
      AddValue.Cost = TowerConfig.UpgradeParams[0].Cost;//По умолчанию стоимость для нового уровня и урон равны
      //базовым значениям
      AddValue.Damage = TowerConfig.UpgradeParams[0].Damage;
      TowerConfig.UpgradeParams.Insert(InsertPos, AddValue);
    }

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
    }

    public void LimitedShow(int ShowLevel)
    {
      if (ShowLevel >= TowerConfig.UpgradeParams.Count)
        return;
      mTBlCost.Text = TowerConfig.UpgradeParams[ShowLevel].Cost.ToString();
      mTBlDamage.Text = TowerConfig.UpgradeParams[ShowLevel].Damage.ToString();
      mTBlRadius.Text = TowerConfig.UpgradeParams[ShowLevel].AttackRadius.ToString();
    }
    #endregion

    //Создание новой башни
    private void BNewTowerConf_Click(object sender, EventArgs e)
    {
      GBTowerConf.Enabled = true;
      TowerConfig = sTowerParam.CreateDefault();
      CurrentUpLevel = 0;
    }

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

    //Установление эффекта
    private void RBNoEffect_Click(object sender, EventArgs e)
    {
      TowerConfig.Modificator = (eModificatorName)Convert.ToInt32((sender as RadioButton).Tag);
    }

    //Установление TrueSight свойства
    private void CBTrueSight_CheckedChanged(object sender, EventArgs e)
    {
      TowerConfig.TrueSight = CBTrueSight.Checked;
    }

    //Выбор типа башни
    private void RBSimpleTower_Click(object sender, EventArgs e)
    {
      TowerConfig.TowerType = (eTowerType)Convert.ToInt32((sender as RadioButton).Tag);
    }

    //Получение индекса для уровня башни по имени maskedTextBox'а
    private int GetIndexByName(string Name)
    {
      if (Name.IndexOf("mTBl") != -1)//Если мы попали сюда из LimitedUpgrade
        return 0;
      else if (Name.IndexOf("mTBu") != -1)//из UnlimitedUpgrade
        return 0;
      else//Если это первоначальные настройки
        return 0;
    }

    //Изменение текста в TextBox'ах, задающих параметры
    private void maskedTextBoxChanged(object sender, EventArgs e)
    {
      if ((sender as MaskedTextBox) == null)
      {
        MessageBox.Show("BAD BAD BAD programmer again! Used metod incorrect. KILL HIM");
        return;
      }
      if ((sender as MaskedTextBox).Text == string.Empty)
        return;
      int index = GetIndexByName((sender as MaskedTextBox).Name);
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
        double Tmp = Convert.ToByte(ValueToChange);
        double.TryParse(TextForValidate, out Tmp);
        ValueToChange = Tmp;
      }
      else
        MessageBox.Show("Method \"ValidateAndChange\" used wrong!");
    }

    //Проверка множителя критического удара
    private void TBCritMultiple_TextChanged(object sender, EventArgs e)
    {
      if ((sender as TextBox).Text == string.Empty)
        return;
      sMainTowerParam Tmp = TowerConfig.UpgradeParams[GetIndexByName((sender as TextBox).Name)];
      object TmpValue = Tmp.CritMultiple;
      ValidateAndChange((sender as MaskedTextBox).Text, ref TmpValue);
      TowerConfig.UpgradeParams[GetIndexByName((sender as TextBox).Name)] = Tmp;
    }

    //On/Off критического удара
    private void CBEnableCrit_CheckedChanged(object sender, EventArgs e)
    {
      PCriticalStrikeSettings.Enabled = CBEnableCrit.Checked;
    }
  }
}
