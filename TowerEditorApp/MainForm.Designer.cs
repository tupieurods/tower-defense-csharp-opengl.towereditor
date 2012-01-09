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
      this.GBLimitedUp = new System.Windows.Forms.GroupBox();
      this.mTBlUpRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBlUpDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBlUpCost = new System.Windows.Forms.MaskedTextBox();
      this.BlNextUp = new System.Windows.Forms.Button();
      this.BlPreviousUp = new System.Windows.Forms.Button();
      this.LlUpNewRadius = new System.Windows.Forms.Label();
      this.LlUpNewDamage = new System.Windows.Forms.Label();
      this.LlUpCost = new System.Windows.Forms.Label();
      this.GBUnlimitedUp = new System.Windows.Forms.GroupBox();
      this.mTBuUpRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBuUpDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBuUpCost = new System.Windows.Forms.MaskedTextBox();
      this.LuUpAdditionalRadius = new System.Windows.Forms.Label();
      this.LuUpDamage = new System.Windows.Forms.Label();
      this.LuUpCost = new System.Windows.Forms.Label();
      this.GPUpType = new System.Windows.Forms.GroupBox();
      this.RBLimitedUp = new System.Windows.Forms.RadioButton();
      this.RBUnlimitedUp = new System.Windows.Forms.RadioButton();
      this.mTBTowerAttackRadius = new System.Windows.Forms.MaskedTextBox();
      this.mTBTowerDamage = new System.Windows.Forms.MaskedTextBox();
      this.mTBTowerCost = new System.Windows.Forms.MaskedTextBox();
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
      this.BlAddUp = new System.Windows.Forms.Button();
      this.BlRemoveUp = new System.Windows.Forms.Button();
      this.GBTowerConf.SuspendLayout();
      this.GBLimitedUp.SuspendLayout();
      this.GBUnlimitedUp.SuspendLayout();
      this.GPUpType.SuspendLayout();
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
      this.GBTowerConf.Controls.Add(this.GBLimitedUp);
      this.GBTowerConf.Controls.Add(this.GBUnlimitedUp);
      this.GBTowerConf.Controls.Add(this.GPUpType);
      this.GBTowerConf.Controls.Add(this.mTBTowerAttackRadius);
      this.GBTowerConf.Controls.Add(this.mTBTowerDamage);
      this.GBTowerConf.Controls.Add(this.mTBTowerCost);
      this.GBTowerConf.Controls.Add(this.LTowerAttackRadius);
      this.GBTowerConf.Controls.Add(this.LTowerDamage);
      this.GBTowerConf.Controls.Add(this.LCostTower);
      this.GBTowerConf.Controls.Add(this.GBTowerType);
      this.GBTowerConf.Controls.Add(this.PLoadPictures);
      this.GBTowerConf.Location = new System.Drawing.Point(12, 75);
      this.GBTowerConf.Name = "GBTowerConf";
      this.GBTowerConf.Size = new System.Drawing.Size(720, 400);
      this.GBTowerConf.TabIndex = 3;
      this.GBTowerConf.TabStop = false;
      this.GBTowerConf.Text = "Tower configuration";
      // 
      // GBLimitedUp
      // 
      this.GBLimitedUp.Controls.Add(this.BlRemoveUp);
      this.GBLimitedUp.Controls.Add(this.BlAddUp);
      this.GBLimitedUp.Controls.Add(this.mTBlUpRadius);
      this.GBLimitedUp.Controls.Add(this.mTBlUpDamage);
      this.GBLimitedUp.Controls.Add(this.mTBlUpCost);
      this.GBLimitedUp.Controls.Add(this.BlNextUp);
      this.GBLimitedUp.Controls.Add(this.BlPreviousUp);
      this.GBLimitedUp.Controls.Add(this.LlUpNewRadius);
      this.GBLimitedUp.Controls.Add(this.LlUpNewDamage);
      this.GBLimitedUp.Controls.Add(this.LlUpCost);
      this.GBLimitedUp.Location = new System.Drawing.Point(364, 219);
      this.GBLimitedUp.Name = "GBLimitedUp";
      this.GBLimitedUp.Size = new System.Drawing.Size(348, 175);
      this.GBLimitedUp.TabIndex = 14;
      this.GBLimitedUp.TabStop = false;
      this.GBLimitedUp.Text = "Limited upgrade";
      // 
      // mTBlUpRadius
      // 
      this.mTBlUpRadius.Location = new System.Drawing.Point(137, 91);
      this.mTBlUpRadius.Mask = "0000";
      this.mTBlUpRadius.Name = "mTBlUpRadius";
      this.mTBlUpRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBlUpRadius.TabIndex = 10;
      // 
      // mTBlUpDamage
      // 
      this.mTBlUpDamage.Location = new System.Drawing.Point(137, 56);
      this.mTBlUpDamage.Mask = "00000";
      this.mTBlUpDamage.Name = "mTBlUpDamage";
      this.mTBlUpDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBlUpDamage.TabIndex = 9;
      this.mTBlUpDamage.ValidatingType = typeof(int);
      // 
      // mTBlUpCost
      // 
      this.mTBlUpCost.Location = new System.Drawing.Point(137, 22);
      this.mTBlUpCost.Mask = "00000";
      this.mTBlUpCost.Name = "mTBlUpCost";
      this.mTBlUpCost.Size = new System.Drawing.Size(100, 29);
      this.mTBlUpCost.TabIndex = 8;
      this.mTBlUpCost.ValidatingType = typeof(int);
      // 
      // BlNextUp
      // 
      this.BlNextUp.Location = new System.Drawing.Point(185, 133);
      this.BlNextUp.Name = "BlNextUp";
      this.BlNextUp.Size = new System.Drawing.Size(157, 36);
      this.BlNextUp.TabIndex = 7;
      this.BlNextUp.Text = "Next upgrade";
      this.BlNextUp.UseVisualStyleBackColor = true;
      // 
      // BlPreviousUp
      // 
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
      this.LlUpNewRadius.Location = new System.Drawing.Point(6, 96);
      this.LlUpNewRadius.Name = "LlUpNewRadius";
      this.LlUpNewRadius.Size = new System.Drawing.Size(105, 24);
      this.LlUpNewRadius.TabIndex = 5;
      this.LlUpNewRadius.Text = "New radius";
      // 
      // LlUpNewDamage
      // 
      this.LlUpNewDamage.AutoSize = true;
      this.LlUpNewDamage.Location = new System.Drawing.Point(6, 61);
      this.LlUpNewDamage.Name = "LlUpNewDamage";
      this.LlUpNewDamage.Size = new System.Drawing.Size(125, 24);
      this.LlUpNewDamage.TabIndex = 4;
      this.LlUpNewDamage.Text = "New Damage";
      // 
      // LlUpCost
      // 
      this.LlUpCost.AutoSize = true;
      this.LlUpCost.Location = new System.Drawing.Point(6, 25);
      this.LlUpCost.Name = "LlUpCost";
      this.LlUpCost.Size = new System.Drawing.Size(122, 24);
      this.LlUpCost.TabIndex = 3;
      this.LlUpCost.Text = "Upgrade cost";
      // 
      // GBUnlimitedUp
      // 
      this.GBUnlimitedUp.Controls.Add(this.mTBuUpRadius);
      this.GBUnlimitedUp.Controls.Add(this.mTBuUpDamage);
      this.GBUnlimitedUp.Controls.Add(this.mTBuUpCost);
      this.GBUnlimitedUp.Controls.Add(this.LuUpAdditionalRadius);
      this.GBUnlimitedUp.Controls.Add(this.LuUpDamage);
      this.GBUnlimitedUp.Controls.Add(this.LuUpCost);
      this.GBUnlimitedUp.Location = new System.Drawing.Point(6, 219);
      this.GBUnlimitedUp.Name = "GBUnlimitedUp";
      this.GBUnlimitedUp.Size = new System.Drawing.Size(352, 175);
      this.GBUnlimitedUp.TabIndex = 13;
      this.GBUnlimitedUp.TabStop = false;
      this.GBUnlimitedUp.Text = "Unlimited upgrade";
      // 
      // mTBuUpRadius
      // 
      this.mTBuUpRadius.Location = new System.Drawing.Point(249, 91);
      this.mTBuUpRadius.Mask = "0000";
      this.mTBuUpRadius.Name = "mTBuUpRadius";
      this.mTBuUpRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBuUpRadius.TabIndex = 13;
      // 
      // mTBuUpDamage
      // 
      this.mTBuUpDamage.Location = new System.Drawing.Point(249, 56);
      this.mTBuUpDamage.Mask = "00000";
      this.mTBuUpDamage.Name = "mTBuUpDamage";
      this.mTBuUpDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBuUpDamage.TabIndex = 12;
      this.mTBuUpDamage.ValidatingType = typeof(int);
      // 
      // mTBuUpCost
      // 
      this.mTBuUpCost.Location = new System.Drawing.Point(249, 22);
      this.mTBuUpCost.Mask = "00000";
      this.mTBuUpCost.Name = "mTBuUpCost";
      this.mTBuUpCost.Size = new System.Drawing.Size(100, 29);
      this.mTBuUpCost.TabIndex = 11;
      this.mTBuUpCost.ValidatingType = typeof(int);
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
      // GPUpType
      // 
      this.GPUpType.Controls.Add(this.RBLimitedUp);
      this.GPUpType.Controls.Add(this.RBUnlimitedUp);
      this.GPUpType.Location = new System.Drawing.Point(170, 155);
      this.GPUpType.Name = "GPUpType";
      this.GPUpType.Size = new System.Drawing.Size(360, 58);
      this.GPUpType.TabIndex = 12;
      this.GPUpType.TabStop = false;
      this.GPUpType.Text = "UpgradeType";
      // 
      // RBLimitedUp
      // 
      this.RBLimitedUp.AutoSize = true;
      this.RBLimitedUp.Location = new System.Drawing.Point(194, 28);
      this.RBLimitedUp.Name = "RBLimitedUp";
      this.RBLimitedUp.Size = new System.Drawing.Size(164, 28);
      this.RBLimitedUp.TabIndex = 13;
      this.RBLimitedUp.Text = "Limited upgrade";
      this.RBLimitedUp.UseVisualStyleBackColor = true;
      // 
      // RBUnlimitedUp
      // 
      this.RBUnlimitedUp.AutoSize = true;
      this.RBUnlimitedUp.Checked = true;
      this.RBUnlimitedUp.Location = new System.Drawing.Point(6, 28);
      this.RBUnlimitedUp.Name = "RBUnlimitedUp";
      this.RBUnlimitedUp.Size = new System.Drawing.Size(182, 28);
      this.RBUnlimitedUp.TabIndex = 13;
      this.RBUnlimitedUp.TabStop = true;
      this.RBUnlimitedUp.Text = "Unlimited upgrade";
      this.RBUnlimitedUp.UseVisualStyleBackColor = true;
      // 
      // mTBTowerAttackRadius
      // 
      this.mTBTowerAttackRadius.Location = new System.Drawing.Point(606, 111);
      this.mTBTowerAttackRadius.Mask = "0000";
      this.mTBTowerAttackRadius.Name = "mTBTowerAttackRadius";
      this.mTBTowerAttackRadius.Size = new System.Drawing.Size(100, 29);
      this.mTBTowerAttackRadius.TabIndex = 11;
      this.mTBTowerAttackRadius.Text = "100";
      // 
      // mTBTowerDamage
      // 
      this.mTBTowerDamage.Location = new System.Drawing.Point(606, 72);
      this.mTBTowerDamage.Mask = "00000";
      this.mTBTowerDamage.Name = "mTBTowerDamage";
      this.mTBTowerDamage.Size = new System.Drawing.Size(100, 29);
      this.mTBTowerDamage.TabIndex = 10;
      this.mTBTowerDamage.Text = "50";
      this.mTBTowerDamage.ValidatingType = typeof(int);
      // 
      // mTBTowerCost
      // 
      this.mTBTowerCost.Location = new System.Drawing.Point(606, 36);
      this.mTBTowerCost.Mask = "00000";
      this.mTBTowerCost.Name = "mTBTowerCost";
      this.mTBTowerCost.Size = new System.Drawing.Size(100, 29);
      this.mTBTowerCost.TabIndex = 9;
      this.mTBTowerCost.Text = "40";
      this.mTBTowerCost.ValidatingType = typeof(int);
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
      this.RBSplashTower.AutoSize = true;
      this.RBSplashTower.Location = new System.Drawing.Point(18, 62);
      this.RBSplashTower.Name = "RBSplashTower";
      this.RBSplashTower.Size = new System.Drawing.Size(136, 28);
      this.RBSplashTower.TabIndex = 1;
      this.RBSplashTower.Text = "Splash tower";
      this.RBSplashTower.UseVisualStyleBackColor = true;
      // 
      // RBSimpleTower
      // 
      this.RBSimpleTower.AutoSize = true;
      this.RBSimpleTower.Checked = true;
      this.RBSimpleTower.Location = new System.Drawing.Point(18, 28);
      this.RBSimpleTower.Name = "RBSimpleTower";
      this.RBSimpleTower.Size = new System.Drawing.Size(137, 28);
      this.RBSimpleTower.TabIndex = 0;
      this.RBSimpleTower.TabStop = true;
      this.RBSimpleTower.Text = "Simple tower";
      this.RBSimpleTower.UseVisualStyleBackColor = true;
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
      // BlAddUp
      // 
      this.BlAddUp.Location = new System.Drawing.Point(243, 25);
      this.BlAddUp.Name = "BlAddUp";
      this.BlAddUp.Size = new System.Drawing.Size(99, 36);
      this.BlAddUp.TabIndex = 11;
      this.BlAddUp.Text = "Add";
      this.BlAddUp.UseVisualStyleBackColor = true;
      // 
      // BlRemoveUp
      // 
      this.BlRemoveUp.Location = new System.Drawing.Point(242, 67);
      this.BlRemoveUp.Name = "BlRemoveUp";
      this.BlRemoveUp.Size = new System.Drawing.Size(99, 36);
      this.BlRemoveUp.TabIndex = 12;
      this.BlRemoveUp.Text = "Remove";
      this.BlRemoveUp.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(740, 485);
      this.Controls.Add(this.GBTowerConf);
      this.Controls.Add(this.BLoad);
      this.Controls.Add(this.BSave);
      this.Controls.Add(this.BNewTowerConf);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "MainForm";
      this.Text = "Tower editor";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.GBTowerConf.ResumeLayout(false);
      this.GBTowerConf.PerformLayout();
      this.GBLimitedUp.ResumeLayout(false);
      this.GBLimitedUp.PerformLayout();
      this.GBUnlimitedUp.ResumeLayout(false);
      this.GBUnlimitedUp.PerformLayout();
      this.GPUpType.ResumeLayout(false);
      this.GPUpType.PerformLayout();
      this.GBTowerType.ResumeLayout(false);
      this.GBTowerType.PerformLayout();
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
    private System.Windows.Forms.MaskedTextBox mTBTowerAttackRadius;
    private System.Windows.Forms.MaskedTextBox mTBTowerDamage;
    private System.Windows.Forms.MaskedTextBox mTBTowerCost;
    private System.Windows.Forms.GroupBox GPUpType;
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
    private System.Windows.Forms.MaskedTextBox mTBlUpRadius;
    private System.Windows.Forms.MaskedTextBox mTBlUpDamage;
    private System.Windows.Forms.MaskedTextBox mTBlUpCost;
    private System.Windows.Forms.MaskedTextBox mTBuUpRadius;
    private System.Windows.Forms.MaskedTextBox mTBuUpDamage;
    private System.Windows.Forms.MaskedTextBox mTBuUpCost;
    private System.Windows.Forms.Button BlRemoveUp;
    private System.Windows.Forms.Button BlAddUp;
  }
}

