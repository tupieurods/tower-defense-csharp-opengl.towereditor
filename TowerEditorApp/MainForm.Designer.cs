namespace TowerEditorApp
{
  partial class MainForm
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.BNewTowerConf = new System.Windows.Forms.Button();
      this.BSave = new System.Windows.Forms.Button();
      this.BLoad = new System.Windows.Forms.Button();
      this.GBTowerConf = new System.Windows.Forms.GroupBox();
      this.CBTrueSight = new System.Windows.Forms.CheckBox();
      this.GBMissleColor = new System.Windows.Forms.GroupBox();
      this.PBMissleBrushColor = new System.Windows.Forms.PictureBox();
      this.PBMisslePenColor = new System.Windows.Forms.PictureBox();
      this.BSelectBrushColor = new System.Windows.Forms.Button();
      this.BSelectPenColor = new System.Windows.Forms.Button();
      this.GBSpecialEffects = new System.Windows.Forms.GroupBox();
      this.RBNoEffect = new System.Windows.Forms.RadioButton();
      this.RBPosionEffect = new System.Windows.Forms.RadioButton();
      this.RBBurnEffect = new System.Windows.Forms.RadioButton();
      this.RBFreezeEffect = new System.Windows.Forms.RadioButton();
      this.mTBNumberOfTargets = new System.Windows.Forms.MaskedTextBox();
      this.LNumberOfTargets = new System.Windows.Forms.Label();
      this.CBEnableCrit = new System.Windows.Forms.CheckBox();
      this.PCriticalStrikeSettings = new System.Windows.Forms.Panel();
      this.TBCritMultiple = new System.Windows.Forms.TextBox();
      this.mTBCritChance = new System.Windows.Forms.MaskedTextBox();
      this.LCritChance = new System.Windows.Forms.Label();
      this.LCritMultiple = new System.Windows.Forms.Label();
      this.GBLimitedUp = new System.Windows.Forms.GroupBox();
      this.BlRemoveUp = new System.Windows.Forms.Button();
      this.BlAddUp = new System.Windows.Forms.Button();
      this.mTBlRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBlDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBlCost = new System.Windows.Forms.MaskedTextBox();
      this.BlNextUp = new System.Windows.Forms.Button();
      this.BlPreviousUp = new System.Windows.Forms.Button();
      this.LlUpNewRadius = new System.Windows.Forms.Label();
      this.LlUpNewDamage = new System.Windows.Forms.Label();
      this.LlUpCost = new System.Windows.Forms.Label();
      this.GBUnlimitedUp = new System.Windows.Forms.GroupBox();
      this.mTBuRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBuDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBuCost = new System.Windows.Forms.MaskedTextBox();
      this.LuUpAdditionalRadius = new System.Windows.Forms.Label();
      this.LuUpDamage = new System.Windows.Forms.Label();
      this.LuUpCost = new System.Windows.Forms.Label();
      this.GBUpType = new System.Windows.Forms.GroupBox();
      this.RBNoUp = new System.Windows.Forms.RadioButton();
      this.RBLimitedUp = new System.Windows.Forms.RadioButton();
      this.RBUnlimitedUp = new System.Windows.Forms.RadioButton();
      this.mTBRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBCost = new System.Windows.Forms.MaskedTextBox();
      this.LTowerAttackRadius = new System.Windows.Forms.Label();
      this.LTowerDamage = new System.Windows.Forms.Label();
      this.LCostTower = new System.Windows.Forms.Label();
      this.GBTowerType = new System.Windows.Forms.GroupBox();
      this.RBSplashTower = new System.Windows.Forms.RadioButton();
      this.RBSimpleTower = new System.Windows.Forms.RadioButton();
      this.PLoadPictures = new System.Windows.Forms.Panel();
      this.BLoadTowerBitmap = new System.Windows.Forms.Button();
      this.PBTowerBitmap = new System.Windows.Forms.PictureBox();
      this.PBTowerIcon = new System.Windows.Forms.PictureBox();
      this.BLoadTowerIcon = new System.Windows.Forms.Button();
      this.GBTowerConf.SuspendLayout();
      this.GBMissleColor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PBMissleBrushColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PBMisslePenColor)).BeginInit();
      this.GBSpecialEffects.SuspendLayout();
      this.PCriticalStrikeSettings.SuspendLayout();
      this.GBLimitedUp.SuspendLayout();
      this.GBUnlimitedUp.SuspendLayout();
      this.GBUpType.SuspendLayout();
      this.GBTowerType.SuspendLayout();
      this.PLoadPictures.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PBTowerBitmap)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PBTowerIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // BNewTowerConf
      // 
      this.BNewTowerConf.Location = new System.Drawing.Point(12, 12);
      this.BNewTowerConf.Name = "BNewTowerConf";
      this.BNewTowerConf.Size = new System.Drawing.Size(224, 31);
      this.BNewTowerConf.TabIndex = 0;
      this.BNewTowerConf.Text = "New tower configuration";
      this.BNewTowerConf.UseVisualStyleBackColor = true;
      this.BNewTowerConf.Click += new System.EventHandler(this.BNewTowerConf_Click);
      // 
      // BSave
      // 
      this.BSave.Location = new System.Drawing.Point(242, 12);
      this.BSave.Name = "BSave";
      this.BSave.Size = new System.Drawing.Size(75, 31);
      this.BSave.TabIndex = 1;
      this.BSave.Text = "Save";
      this.BSave.UseVisualStyleBackColor = true;
      // 
      // BLoad
      // 
      this.BLoad.Location = new System.Drawing.Point(323, 11);
      this.BLoad.Name = "BLoad";
      this.BLoad.Size = new System.Drawing.Size(75, 32);
      this.BLoad.TabIndex = 2;
      this.BLoad.Text = "Load";
      this.BLoad.UseVisualStyleBackColor = true;
      // 
      // GBTowerConf
      // 
      this.GBTowerConf.Controls.Add(this.CBTrueSight);
      this.GBTowerConf.Controls.Add(this.GBMissleColor);
      this.GBTowerConf.Controls.Add(this.GBSpecialEffects);
      this.GBTowerConf.Controls.Add(this.mTBNumberOfTargets);
      this.GBTowerConf.Controls.Add(this.LNumberOfTargets);
      this.GBTowerConf.Controls.Add(this.CBEnableCrit);
      this.GBTowerConf.Controls.Add(this.PCriticalStrikeSettings);
      this.GBTowerConf.Controls.Add(this.GBLimitedUp);
      this.GBTowerConf.Controls.Add(this.GBUnlimitedUp);
      this.GBTowerConf.Controls.Add(this.GBUpType);
      this.GBTowerConf.Controls.Add(this.mTBRadius);
      this.GBTowerConf.Controls.Add(this.mTBDamage);
      this.GBTowerConf.Controls.Add(this.mTBCost);
      this.GBTowerConf.Controls.Add(this.LTowerAttackRadius);
      this.GBTowerConf.Controls.Add(this.LTowerDamage);
      this.GBTowerConf.Controls.Add(this.LCostTower);
      this.GBTowerConf.Controls.Add(this.GBTowerType);
      this.GBTowerConf.Controls.Add(this.PLoadPictures);
      this.GBTowerConf.Enabled = false;
      this.GBTowerConf.Location = new System.Drawing.Point(12, 49);
      this.GBTowerConf.Name = "GBTowerConf";
      this.GBTowerConf.Size = new System.Drawing.Size(950, 425);
      this.GBTowerConf.TabIndex = 3;
      this.GBTowerConf.TabStop = false;
      this.GBTowerConf.Text = "Tower configuration";
      // 
      // CBTrueSight
      // 
      this.CBTrueSight.Location = new System.Drawing.Point(582, 189);
      this.CBTrueSight.Name = "CBTrueSight";
      this.CBTrueSight.Size = new System.Drawing.Size(123, 44);
      this.CBTrueSight.TabIndex = 23;
      this.CBTrueSight.Text = "True sight";
      this.CBTrueSight.UseVisualStyleBackColor = true;
      this.CBTrueSight.CheckedChanged += new System.EventHandler(this.CBTrueSight_CheckedChanged);
      // 
      // GBMissleColor
      // 
      this.GBMissleColor.Controls.Add(this.PBMissleBrushColor);
      this.GBMissleColor.Controls.Add(this.PBMisslePenColor);
      this.GBMissleColor.Controls.Add(this.BSelectBrushColor);
      this.GBMissleColor.Controls.Add(this.BSelectPenColor);
      this.GBMissleColor.Location = new System.Drawing.Point(718, 139);
      this.GBMissleColor.Name = "GBMissleColor";
      this.GBMissleColor.Size = new System.Drawing.Size(224, 111);
      this.GBMissleColor.TabIndex = 22;
      this.GBMissleColor.TabStop = false;
      this.GBMissleColor.Text = "Missle color select";
      // 
      // PBMissleBrushColor
      // 
      this.PBMissleBrushColor.Location = new System.Drawing.Point(190, 70);
      this.PBMissleBrushColor.Name = "PBMissleBrushColor";
      this.PBMissleBrushColor.Size = new System.Drawing.Size(30, 30);
      this.PBMissleBrushColor.TabIndex = 23;
      this.PBMissleBrushColor.TabStop = false;
      // 
      // PBMisslePenColor
      // 
      this.PBMisslePenColor.Location = new System.Drawing.Point(173, 25);
      this.PBMisslePenColor.Name = "PBMisslePenColor";
      this.PBMisslePenColor.Size = new System.Drawing.Size(30, 30);
      this.PBMisslePenColor.TabIndex = 22;
      this.PBMisslePenColor.TabStop = false;
      // 
      // BSelectBrushColor
      // 
      this.BSelectBrushColor.Location = new System.Drawing.Point(6, 70);
      this.BSelectBrushColor.Name = "BSelectBrushColor";
      this.BSelectBrushColor.Size = new System.Drawing.Size(178, 30);
      this.BSelectBrushColor.TabIndex = 21;
      this.BSelectBrushColor.Text = "Select brush color";
      this.BSelectBrushColor.UseVisualStyleBackColor = true;
      // 
      // BSelectPenColor
      // 
      this.BSelectPenColor.Location = new System.Drawing.Point(6, 25);
      this.BSelectPenColor.Name = "BSelectPenColor";
      this.BSelectPenColor.Size = new System.Drawing.Size(161, 31);
      this.BSelectPenColor.TabIndex = 20;
      this.BSelectPenColor.Text = "Select pen color";
      this.BSelectPenColor.UseVisualStyleBackColor = true;
      // 
      // GBSpecialEffects
      // 
      this.GBSpecialEffects.Controls.Add(this.RBNoEffect);
      this.GBSpecialEffects.Controls.Add(this.RBPosionEffect);
      this.GBSpecialEffects.Controls.Add(this.RBBurnEffect);
      this.GBSpecialEffects.Controls.Add(this.RBFreezeEffect);
      this.GBSpecialEffects.Location = new System.Drawing.Point(718, 256);
      this.GBSpecialEffects.Name = "GBSpecialEffects";
      this.GBSpecialEffects.Size = new System.Drawing.Size(217, 109);
      this.GBSpecialEffects.TabIndex = 19;
      this.GBSpecialEffects.TabStop = false;
      this.GBSpecialEffects.Text = "Special effects";
      // 
      // RBNoEffect
      // 
      this.RBNoEffect.Checked = true;
      this.RBNoEffect.Location = new System.Drawing.Point(10, 30);
      this.RBNoEffect.Name = "RBNoEffect";
      this.RBNoEffect.Size = new System.Drawing.Size(102, 28);
      this.RBNoEffect.TabIndex = 3;
      this.RBNoEffect.TabStop = true;
      this.RBNoEffect.Tag = "0";
      this.RBNoEffect.Text = "No effect";
      this.RBNoEffect.UseVisualStyleBackColor = true;
      this.RBNoEffect.Click += new System.EventHandler(this.RBNoEffect_Click);
      // 
      // RBPosionEffect
      // 
      this.RBPosionEffect.Location = new System.Drawing.Point(118, 64);
      this.RBPosionEffect.Name = "RBPosionEffect";
      this.RBPosionEffect.Size = new System.Drawing.Size(95, 28);
      this.RBPosionEffect.TabIndex = 2;
      this.RBPosionEffect.Tag = "3";
      this.RBPosionEffect.Text = "Posion";
      this.RBPosionEffect.UseVisualStyleBackColor = true;
      this.RBPosionEffect.Click += new System.EventHandler(this.RBNoEffect_Click);
      // 
      // RBBurnEffect
      // 
      this.RBBurnEffect.Location = new System.Drawing.Point(10, 64);
      this.RBBurnEffect.Name = "RBBurnEffect";
      this.RBBurnEffect.Size = new System.Drawing.Size(102, 28);
      this.RBBurnEffect.TabIndex = 1;
      this.RBBurnEffect.Tag = "2";
      this.RBBurnEffect.Text = "Burn";
      this.RBBurnEffect.UseVisualStyleBackColor = true;
      this.RBBurnEffect.Click += new System.EventHandler(this.RBNoEffect_Click);
      // 
      // RBFreezeEffect
      // 
      this.RBFreezeEffect.Location = new System.Drawing.Point(118, 30);
      this.RBFreezeEffect.Name = "RBFreezeEffect";
      this.RBFreezeEffect.Size = new System.Drawing.Size(93, 28);
      this.RBFreezeEffect.TabIndex = 0;
      this.RBFreezeEffect.Tag = "1";
      this.RBFreezeEffect.Text = "Freeze";
      this.RBFreezeEffect.UseVisualStyleBackColor = true;
      this.RBFreezeEffect.Click += new System.EventHandler(this.RBNoEffect_Click);
      // 
      // mTBNumberOfTargets
      // 
      this.mTBNumberOfTargets.Location = new System.Drawing.Point(671, 154);
      this.mTBNumberOfTargets.Mask = "00";
      this.mTBNumberOfTargets.Name = "mTBNumberOfTargets";
      this.mTBNumberOfTargets.Size = new System.Drawing.Size(35, 29);
      this.mTBNumberOfTargets.TabIndex = 18;
      this.mTBNumberOfTargets.Text = "1";
      this.mTBNumberOfTargets.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // LNumberOfTargets
      // 
      this.LNumberOfTargets.AutoSize = true;
      this.LNumberOfTargets.Location = new System.Drawing.Point(428, 154);
      this.LNumberOfTargets.Name = "LNumberOfTargets";
      this.LNumberOfTargets.Size = new System.Drawing.Size(244, 24);
      this.LNumberOfTargets.TabIndex = 17;
      this.LNumberOfTargets.Text = "Maximum number of targets";
      // 
      // CBEnableCrit
      // 
      this.CBEnableCrit.Location = new System.Drawing.Point(718, 28);
      this.CBEnableCrit.Name = "CBEnableCrit";
      this.CBEnableCrit.Size = new System.Drawing.Size(217, 27);
      this.CBEnableCrit.TabIndex = 16;
      this.CBEnableCrit.Text = "Critical strike enabled";
      this.CBEnableCrit.UseVisualStyleBackColor = true;
      this.CBEnableCrit.CheckedChanged += new System.EventHandler(this.CBEnableCrit_CheckedChanged);
      // 
      // PCriticalStrikeSettings
      // 
      this.PCriticalStrikeSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PCriticalStrikeSettings.Controls.Add(this.TBCritMultiple);
      this.PCriticalStrikeSettings.Controls.Add(this.mTBCritChance);
      this.PCriticalStrikeSettings.Controls.Add(this.LCritChance);
      this.PCriticalStrikeSettings.Controls.Add(this.LCritMultiple);
      this.PCriticalStrikeSettings.Enabled = false;
      this.PCriticalStrikeSettings.Location = new System.Drawing.Point(718, 56);
      this.PCriticalStrikeSettings.Name = "PCriticalStrikeSettings";
      this.PCriticalStrikeSettings.Size = new System.Drawing.Size(217, 76);
      this.PCriticalStrikeSettings.TabIndex = 15;
      // 
      // TBCritMultiple
      // 
      this.TBCritMultiple.Location = new System.Drawing.Point(112, 4);
      this.TBCritMultiple.MaxLength = 5;
      this.TBCritMultiple.Name = "TBCritMultiple";
      this.TBCritMultiple.Size = new System.Drawing.Size(100, 29);
      this.TBCritMultiple.TabIndex = 4;
      this.TBCritMultiple.Text = "0";
      this.TBCritMultiple.TextChanged += new System.EventHandler(this.TBCritMultiple_TextChanged);
      this.TBCritMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCritMultiple_KeyPress);
      // 
      // mTBCritChance
      // 
      this.mTBCritChance.Location = new System.Drawing.Point(166, 42);
      this.mTBCritChance.Mask = "000";
      this.mTBCritChance.Name = "mTBCritChance";
      this.mTBCritChance.Size = new System.Drawing.Size(46, 29);
      this.mTBCritChance.TabIndex = 3;
      this.mTBCritChance.Text = "0";
      this.mTBCritChance.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // LCritChance
      // 
      this.LCritChance.AutoSize = true;
      this.LCritChance.Location = new System.Drawing.Point(3, 45);
      this.LCritChance.Name = "LCritChance";
      this.LCritChance.Size = new System.Drawing.Size(116, 24);
      this.LCritChance.TabIndex = 1;
      this.LCritChance.Text = "Chance in %";
      // 
      // LCritMultiple
      // 
      this.LCritMultiple.AutoSize = true;
      this.LCritMultiple.Location = new System.Drawing.Point(3, 7);
      this.LCritMultiple.Name = "LCritMultiple";
      this.LCritMultiple.Size = new System.Drawing.Size(75, 24);
      this.LCritMultiple.TabIndex = 0;
      this.LCritMultiple.Text = "Multiple";
      // 
      // GBLimitedUp
      // 
      this.GBLimitedUp.Controls.Add(this.BlRemoveUp);
      this.GBLimitedUp.Controls.Add(this.BlAddUp);
      this.GBLimitedUp.Controls.Add(this.mTBlRadius);
      this.GBLimitedUp.Controls.Add(this.mTBlDamage);
      this.GBLimitedUp.Controls.Add(this.mTBlCost);
      this.GBLimitedUp.Controls.Add(this.BlNextUp);
      this.GBLimitedUp.Controls.Add(this.BlPreviousUp);
      this.GBLimitedUp.Controls.Add(this.LlUpNewRadius);
      this.GBLimitedUp.Controls.Add(this.LlUpNewDamage);
      this.GBLimitedUp.Controls.Add(this.LlUpCost);
      this.GBLimitedUp.Enabled = false;
      this.GBLimitedUp.Location = new System.Drawing.Point(364, 245);
      this.GBLimitedUp.Name = "GBLimitedUp";
      this.GBLimitedUp.Size = new System.Drawing.Size(348, 175);
      this.GBLimitedUp.TabIndex = 14;
      this.GBLimitedUp.TabStop = false;
      this.GBLimitedUp.Text = "Limited upgrade 0/0";
      // 
      // BlRemoveUp
      // 
      this.BlRemoveUp.Enabled = false;
      this.BlRemoveUp.Location = new System.Drawing.Point(242, 67);
      this.BlRemoveUp.Name = "BlRemoveUp";
      this.BlRemoveUp.Size = new System.Drawing.Size(99, 36);
      this.BlRemoveUp.TabIndex = 12;
      this.BlRemoveUp.Text = "Remove";
      this.BlRemoveUp.UseVisualStyleBackColor = true;
      // 
      // BlAddUp
      // 
      this.BlAddUp.Location = new System.Drawing.Point(243, 25);
      this.BlAddUp.Name = "BlAddUp";
      this.BlAddUp.Size = new System.Drawing.Size(99, 36);
      this.BlAddUp.TabIndex = 11;
      this.BlAddUp.Text = "Add";
      this.BlAddUp.UseVisualStyleBackColor = true;
      // 
      // mTBlRadius
      // 
      this.mTBlRadius.Location = new System.Drawing.Point(137, 98);
      this.mTBlRadius.Mask = "0000";
      this.mTBlRadius.Name = "mTBlRadius";
      this.mTBlRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBlRadius.TabIndex = 10;
      this.mTBlRadius.Text = "100";
      this.mTBlRadius.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBlDamage
      // 
      this.mTBlDamage.Location = new System.Drawing.Point(137, 62);
      this.mTBlDamage.Mask = "00000";
      this.mTBlDamage.Name = "mTBlDamage";
      this.mTBlDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBlDamage.TabIndex = 9;
      this.mTBlDamage.Text = "50";
      this.mTBlDamage.ValidatingType = typeof(int);
      this.mTBlDamage.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBlCost
      // 
      this.mTBlCost.Location = new System.Drawing.Point(137, 27);
      this.mTBlCost.Mask = "00000";
      this.mTBlCost.Name = "mTBlCost";
      this.mTBlCost.Size = new System.Drawing.Size(100, 29);
      this.mTBlCost.TabIndex = 8;
      this.mTBlCost.Text = "40";
      this.mTBlCost.ValidatingType = typeof(int);
      this.mTBlCost.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // BlNextUp
      // 
      this.BlNextUp.Enabled = false;
      this.BlNextUp.Location = new System.Drawing.Point(185, 133);
      this.BlNextUp.Name = "BlNextUp";
      this.BlNextUp.Size = new System.Drawing.Size(157, 36);
      this.BlNextUp.TabIndex = 7;
      this.BlNextUp.Text = "Next upgrade";
      this.BlNextUp.UseVisualStyleBackColor = true;
      // 
      // BlPreviousUp
      // 
      this.BlPreviousUp.Enabled = false;
      this.BlPreviousUp.Location = new System.Drawing.Point(6, 133);
      this.BlPreviousUp.Name = "BlPreviousUp";
      this.BlPreviousUp.Size = new System.Drawing.Size(173, 36);
      this.BlPreviousUp.TabIndex = 6;
      this.BlPreviousUp.Text = "Previous upgrade";
      this.BlPreviousUp.UseVisualStyleBackColor = true;
      // 
      // LlUpNewRadius
      // 
      this.LlUpNewRadius.AutoSize = true;
      this.LlUpNewRadius.Location = new System.Drawing.Point(6, 103);
      this.LlUpNewRadius.Name = "LlUpNewRadius";
      this.LlUpNewRadius.Size = new System.Drawing.Size(105, 24);
      this.LlUpNewRadius.TabIndex = 5;
      this.LlUpNewRadius.Text = "New radius";
      // 
      // LlUpNewDamage
      // 
      this.LlUpNewDamage.AutoSize = true;
      this.LlUpNewDamage.Location = new System.Drawing.Point(6, 67);
      this.LlUpNewDamage.Name = "LlUpNewDamage";
      this.LlUpNewDamage.Size = new System.Drawing.Size(125, 24);
      this.LlUpNewDamage.TabIndex = 4;
      this.LlUpNewDamage.Text = "New Damage";
      // 
      // LlUpCost
      // 
      this.LlUpCost.AutoSize = true;
      this.LlUpCost.Location = new System.Drawing.Point(6, 32);
      this.LlUpCost.Name = "LlUpCost";
      this.LlUpCost.Size = new System.Drawing.Size(122, 24);
      this.LlUpCost.TabIndex = 3;
      this.LlUpCost.Text = "Upgrade cost";
      // 
      // GBUnlimitedUp
      // 
      this.GBUnlimitedUp.Controls.Add(this.mTBuRadius);
      this.GBUnlimitedUp.Controls.Add(this.mTBuDamage);
      this.GBUnlimitedUp.Controls.Add(this.mTBuCost);
      this.GBUnlimitedUp.Controls.Add(this.LuUpAdditionalRadius);
      this.GBUnlimitedUp.Controls.Add(this.LuUpDamage);
      this.GBUnlimitedUp.Controls.Add(this.LuUpCost);
      this.GBUnlimitedUp.Enabled = false;
      this.GBUnlimitedUp.Location = new System.Drawing.Point(6, 245);
      this.GBUnlimitedUp.Name = "GBUnlimitedUp";
      this.GBUnlimitedUp.Size = new System.Drawing.Size(352, 175);
      this.GBUnlimitedUp.TabIndex = 13;
      this.GBUnlimitedUp.TabStop = false;
      this.GBUnlimitedUp.Text = "Unlimited upgrade";
      // 
      // mTBuRadius
      // 
      this.mTBuRadius.Location = new System.Drawing.Point(249, 91);
      this.mTBuRadius.Mask = "0000";
      this.mTBuRadius.Name = "mTBuRadius";
      this.mTBuRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBuRadius.TabIndex = 13;
      this.mTBuRadius.Text = "0";
      this.mTBuRadius.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBuDamage
      // 
      this.mTBuDamage.Location = new System.Drawing.Point(249, 56);
      this.mTBuDamage.Mask = "00000";
      this.mTBuDamage.Name = "mTBuDamage";
      this.mTBuDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBuDamage.TabIndex = 12;
      this.mTBuDamage.Text = "50";
      this.mTBuDamage.ValidatingType = typeof(int);
      this.mTBuDamage.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBuCost
      // 
      this.mTBuCost.Location = new System.Drawing.Point(249, 22);
      this.mTBuCost.Mask = "00000";
      this.mTBuCost.Name = "mTBuCost";
      this.mTBuCost.Size = new System.Drawing.Size(100, 29);
      this.mTBuCost.TabIndex = 11;
      this.mTBuCost.Text = "40";
      this.mTBuCost.ValidatingType = typeof(int);
      this.mTBuCost.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // LuUpAdditionalRadius
      // 
      this.LuUpAdditionalRadius.AutoSize = true;
      this.LuUpAdditionalRadius.Location = new System.Drawing.Point(6, 96);
      this.LuUpAdditionalRadius.Name = "LuUpAdditionalRadius";
      this.LuUpAdditionalRadius.Size = new System.Drawing.Size(149, 24);
      this.LuUpAdditionalRadius.TabIndex = 2;
      this.LuUpAdditionalRadius.Text = "Additional radius";
      // 
      // LuUpDamage
      // 
      this.LuUpDamage.AutoSize = true;
      this.LuUpDamage.Location = new System.Drawing.Point(6, 61);
      this.LuUpDamage.Name = "LuUpDamage";
      this.LuUpDamage.Size = new System.Drawing.Size(242, 24);
      this.LuUpDamage.TabIndex = 1;
      this.LuUpDamage.Text = "Upgrade additional damage";
      // 
      // LuUpCost
      // 
      this.LuUpCost.AutoSize = true;
      this.LuUpCost.Location = new System.Drawing.Point(6, 25);
      this.LuUpCost.Name = "LuUpCost";
      this.LuUpCost.Size = new System.Drawing.Size(122, 24);
      this.LuUpCost.TabIndex = 0;
      this.LuUpCost.Text = "Upgrade cost";
      // 
      // GBUpType
      // 
      this.GBUpType.Controls.Add(this.RBNoUp);
      this.GBUpType.Controls.Add(this.RBLimitedUp);
      this.GBUpType.Controls.Add(this.RBUnlimitedUp);
      this.GBUpType.Location = new System.Drawing.Point(6, 181);
      this.GBUpType.Name = "GBUpType";
      this.GBUpType.Size = new System.Drawing.Size(501, 58);
      this.GBUpType.TabIndex = 12;
      this.GBUpType.TabStop = false;
      this.GBUpType.Tag = "2";
      this.GBUpType.Text = "UpgradeType";
      // 
      // RBNoUp
      // 
      this.RBNoUp.Checked = true;
      this.RBNoUp.Location = new System.Drawing.Point(357, 24);
      this.RBNoUp.Name = "RBNoUp";
      this.RBNoUp.Size = new System.Drawing.Size(129, 28);
      this.RBNoUp.TabIndex = 14;
      this.RBNoUp.TabStop = true;
      this.RBNoUp.Text = "No upgrade";
      this.RBNoUp.UseVisualStyleBackColor = true;
      this.RBNoUp.Click += new System.EventHandler(this.RBNoUp_Click);
      // 
      // RBLimitedUp
      // 
      this.RBLimitedUp.Location = new System.Drawing.Point(194, 24);
      this.RBLimitedUp.Name = "RBLimitedUp";
      this.RBLimitedUp.Size = new System.Drawing.Size(164, 28);
      this.RBLimitedUp.TabIndex = 13;
      this.RBLimitedUp.Text = "Limited upgrade";
      this.RBLimitedUp.UseVisualStyleBackColor = true;
      this.RBLimitedUp.Click += new System.EventHandler(this.RBLimitedUp_Click);
      // 
      // RBUnlimitedUp
      // 
      this.RBUnlimitedUp.Location = new System.Drawing.Point(6, 24);
      this.RBUnlimitedUp.Name = "RBUnlimitedUp";
      this.RBUnlimitedUp.Size = new System.Drawing.Size(182, 28);
      this.RBUnlimitedUp.TabIndex = 13;
      this.RBUnlimitedUp.Text = "Unlimited upgrade";
      this.RBUnlimitedUp.UseVisualStyleBackColor = true;
      this.RBUnlimitedUp.Click += new System.EventHandler(this.RBUnlimitedUp_Click);
      // 
      // mTBRadius
      // 
      this.mTBRadius.Location = new System.Drawing.Point(606, 111);
      this.mTBRadius.Mask = "0000";
      this.mTBRadius.Name = "mTBRadius";
      this.mTBRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBRadius.TabIndex = 11;
      this.mTBRadius.Text = "100";
      this.mTBRadius.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBDamage
      // 
      this.mTBDamage.Location = new System.Drawing.Point(606, 72);
      this.mTBDamage.Mask = "00000";
      this.mTBDamage.Name = "mTBDamage";
      this.mTBDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBDamage.TabIndex = 10;
      this.mTBDamage.Text = "50";
      this.mTBDamage.ValidatingType = typeof(int);
      this.mTBDamage.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // mTBCost
      // 
      this.mTBCost.Location = new System.Drawing.Point(606, 36);
      this.mTBCost.Mask = "00000";
      this.mTBCost.Name = "mTBCost";
      this.mTBCost.Size = new System.Drawing.Size(100, 29);
      this.mTBCost.TabIndex = 9;
      this.mTBCost.Text = "40";
      this.mTBCost.ValidatingType = typeof(int);
      this.mTBCost.TextChanged += new System.EventHandler(this.maskedTextBoxChanged);
      // 
      // LTowerAttackRadius
      // 
      this.LTowerAttackRadius.AutoSize = true;
      this.LTowerAttackRadius.Location = new System.Drawing.Point(428, 115);
      this.LTowerAttackRadius.Name = "LTowerAttackRadius";
      this.LTowerAttackRadius.Size = new System.Drawing.Size(172, 24);
      this.LTowerAttackRadius.TabIndex = 8;
      this.LTowerAttackRadius.Text = "Tower attack radius";
      // 
      // LTowerDamage
      // 
      this.LTowerDamage.AutoSize = true;
      this.LTowerDamage.Location = new System.Drawing.Point(428, 77);
      this.LTowerDamage.Name = "LTowerDamage";
      this.LTowerDamage.Size = new System.Drawing.Size(138, 24);
      this.LTowerDamage.TabIndex = 7;
      this.LTowerDamage.Text = "Tower damage";
      // 
      // LCostTower
      // 
      this.LCostTower.AutoSize = true;
      this.LCostTower.Location = new System.Drawing.Point(428, 39);
      this.LCostTower.Name = "LCostTower";
      this.LCostTower.Size = new System.Drawing.Size(103, 24);
      this.LCostTower.TabIndex = 6;
      this.LCostTower.Text = "Tower cost";
      // 
      // GBTowerType
      // 
      this.GBTowerType.Controls.Add(this.RBSplashTower);
      this.GBTowerType.Controls.Add(this.RBSimpleTower);
      this.GBTowerType.Location = new System.Drawing.Point(255, 28);
      this.GBTowerType.Name = "GBTowerType";
      this.GBTowerType.Size = new System.Drawing.Size(167, 121);
      this.GBTowerType.TabIndex = 5;
      this.GBTowerType.TabStop = false;
      this.GBTowerType.Text = "Tower type";
      // 
      // RBSplashTower
      // 
      this.RBSplashTower.Location = new System.Drawing.Point(7, 62);
      this.RBSplashTower.Name = "RBSplashTower";
      this.RBSplashTower.Size = new System.Drawing.Size(154, 26);
      this.RBSplashTower.TabIndex = 1;
      this.RBSplashTower.Tag = "1";
      this.RBSplashTower.Text = "Splash tower";
      this.RBSplashTower.UseVisualStyleBackColor = true;
      this.RBSplashTower.Click += new System.EventHandler(this.RBSimpleTower_Click);
      // 
      // RBSimpleTower
      // 
      this.RBSimpleTower.Checked = true;
      this.RBSimpleTower.Location = new System.Drawing.Point(7, 28);
      this.RBSimpleTower.Name = "RBSimpleTower";
      this.RBSimpleTower.Size = new System.Drawing.Size(154, 28);
      this.RBSimpleTower.TabIndex = 0;
      this.RBSimpleTower.TabStop = true;
      this.RBSimpleTower.Tag = "0";
      this.RBSimpleTower.Text = "Simple tower";
      this.RBSimpleTower.UseVisualStyleBackColor = true;
      this.RBSimpleTower.Click += new System.EventHandler(this.RBSimpleTower_Click);
      // 
      // PLoadPictures
      // 
      this.PLoadPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PLoadPictures.Controls.Add(this.BLoadTowerBitmap);
      this.PLoadPictures.Controls.Add(this.PBTowerBitmap);
      this.PLoadPictures.Controls.Add(this.PBTowerIcon);
      this.PLoadPictures.Controls.Add(this.BLoadTowerIcon);
      this.PLoadPictures.Location = new System.Drawing.Point(6, 28);
      this.PLoadPictures.Name = "PLoadPictures";
      this.PLoadPictures.Size = new System.Drawing.Size(243, 121);
      this.PLoadPictures.TabIndex = 4;
      // 
      // BLoadTowerBitmap
      // 
      this.BLoadTowerBitmap.Location = new System.Drawing.Point(3, 79);
      this.BLoadTowerBitmap.Name = "BLoadTowerBitmap";
      this.BLoadTowerBitmap.Size = new System.Drawing.Size(177, 32);
      this.BLoadTowerBitmap.TabIndex = 1;
      this.BLoadTowerBitmap.Text = "Load tower bitmap";
      this.BLoadTowerBitmap.UseVisualStyleBackColor = true;
      // 
      // PBTowerBitmap
      // 
      this.PBTowerBitmap.Location = new System.Drawing.Point(186, 81);
      this.PBTowerBitmap.Name = "PBTowerBitmap";
      this.PBTowerBitmap.Size = new System.Drawing.Size(30, 30);
      this.PBTowerBitmap.TabIndex = 2;
      this.PBTowerBitmap.TabStop = false;
      // 
      // PBTowerIcon
      // 
      this.PBTowerIcon.Location = new System.Drawing.Point(163, 3);
      this.PBTowerIcon.Name = "PBTowerIcon";
      this.PBTowerIcon.Size = new System.Drawing.Size(70, 70);
      this.PBTowerIcon.TabIndex = 3;
      this.PBTowerIcon.TabStop = false;
      // 
      // BLoadTowerIcon
      // 
      this.BLoadTowerIcon.Location = new System.Drawing.Point(3, 23);
      this.BLoadTowerIcon.Name = "BLoadTowerIcon";
      this.BLoadTowerIcon.Size = new System.Drawing.Size(154, 32);
      this.BLoadTowerIcon.TabIndex = 0;
      this.BLoadTowerIcon.Text = "Load tower icon";
      this.BLoadTowerIcon.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(968, 485);
      this.Controls.Add(this.GBTowerConf);
      this.Controls.Add(this.BLoad);
      this.Controls.Add(this.BSave);
      this.Controls.Add(this.BNewTowerConf);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "MainForm";
      this.Text = "Tower editor";
      this.GBTowerConf.ResumeLayout(false);
      this.GBTowerConf.PerformLayout();
      this.GBMissleColor.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PBMissleBrushColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PBMisslePenColor)).EndInit();
      this.GBSpecialEffects.ResumeLayout(false);
      this.PCriticalStrikeSettings.ResumeLayout(false);
      this.PCriticalStrikeSettings.PerformLayout();
      this.GBLimitedUp.ResumeLayout(false);
      this.GBLimitedUp.PerformLayout();
      this.GBUnlimitedUp.ResumeLayout(false);
      this.GBUnlimitedUp.PerformLayout();
      this.GBUpType.ResumeLayout(false);
      this.GBTowerType.ResumeLayout(false);
      this.PLoadPictures.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PBTowerBitmap)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PBTowerIcon)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BNewTowerConf;
    private System.Windows.Forms.Button BSave;
    private System.Windows.Forms.Button BLoad;
    private System.Windows.Forms.GroupBox GBTowerConf;
    private System.Windows.Forms.PictureBox PBTowerIcon;
    private System.Windows.Forms.PictureBox PBTowerBitmap;
    private System.Windows.Forms.Button BLoadTowerBitmap;
    private System.Windows.Forms.Button BLoadTowerIcon;
    private System.Windows.Forms.Panel PLoadPictures;
    private System.Windows.Forms.GroupBox GBTowerType;
    private System.Windows.Forms.RadioButton RBSplashTower;
    private System.Windows.Forms.RadioButton RBSimpleTower;
    private System.Windows.Forms.Label LTowerAttackRadius;
    private System.Windows.Forms.Label LTowerDamage;
    private System.Windows.Forms.Label LCostTower;
    private System.Windows.Forms.MaskedTextBox mTBRadius;
    private System.Windows.Forms.MaskedTextBox mTBDamage;
    private System.Windows.Forms.MaskedTextBox mTBCost;
    private System.Windows.Forms.GroupBox GBUpType;
    private System.Windows.Forms.RadioButton RBLimitedUp;
    private System.Windows.Forms.RadioButton RBUnlimitedUp;
    private System.Windows.Forms.GroupBox GBLimitedUp;
    private System.Windows.Forms.GroupBox GBUnlimitedUp;
    private System.Windows.Forms.Label LlUpNewRadius;
    private System.Windows.Forms.Label LlUpNewDamage;
    private System.Windows.Forms.Label LlUpCost;
    private System.Windows.Forms.Label LuUpAdditionalRadius;
    private System.Windows.Forms.Label LuUpDamage;
    private System.Windows.Forms.Label LuUpCost;
    private System.Windows.Forms.Button BlNextUp;
    private System.Windows.Forms.Button BlPreviousUp;
    private System.Windows.Forms.MaskedTextBox mTBlRadius;
    private System.Windows.Forms.MaskedTextBox mTBlDamage;
    private System.Windows.Forms.MaskedTextBox mTBlCost;
    private System.Windows.Forms.MaskedTextBox mTBuRadius;
    private System.Windows.Forms.MaskedTextBox mTBuDamage;
    private System.Windows.Forms.MaskedTextBox mTBuCost;
    private System.Windows.Forms.Button BlRemoveUp;
    private System.Windows.Forms.Button BlAddUp;
    private System.Windows.Forms.RadioButton RBNoUp;
    private System.Windows.Forms.CheckBox CBEnableCrit;
    private System.Windows.Forms.Panel PCriticalStrikeSettings;
    private System.Windows.Forms.TextBox TBCritMultiple;
    private System.Windows.Forms.MaskedTextBox mTBCritChance;
    private System.Windows.Forms.Label LCritChance;
    private System.Windows.Forms.Label LCritMultiple;
    private System.Windows.Forms.MaskedTextBox mTBNumberOfTargets;
    private System.Windows.Forms.Label LNumberOfTargets;
    private System.Windows.Forms.GroupBox GBSpecialEffects;
    private System.Windows.Forms.GroupBox GBMissleColor;
    private System.Windows.Forms.Button BSelectBrushColor;
    private System.Windows.Forms.Button BSelectPenColor;
    private System.Windows.Forms.PictureBox PBMissleBrushColor;
    private System.Windows.Forms.PictureBox PBMisslePenColor;
    private System.Windows.Forms.CheckBox CBTrueSight;
    private System.Windows.Forms.RadioButton RBPosionEffect;
    private System.Windows.Forms.RadioButton RBBurnEffect;
    private System.Windows.Forms.RadioButton RBFreezeEffect;
    private System.Windows.Forms.RadioButton RBNoEffect;
  }
}

