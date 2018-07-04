namespace KryptBit
{
    partial class frmKryptBit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msXbit = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOne = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiAliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AAOn = new System.Windows.Forms.ToolStripMenuItem();
            this.AAOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBitCount = new System.Windows.Forms.GroupBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblLoadData = new System.Windows.Forms.Label();
            this.txtBitCount = new System.Windows.Forms.NumericUpDown();
            this.vScrollbar = new System.Windows.Forms.VScrollBar();
            this.tmrValueUpdater = new System.Windows.Forms.Timer(this.components);
            this.pnlDrawContainer = new System.Windows.Forms.Panel();
            this.cbFilterList = new System.Windows.Forms.ComboBox();
            this.lblAddToStack = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ttHelpBot = new System.Windows.Forms.ToolTip(this.components);
            this.lstFilterStack = new System.Windows.Forms.ListBox();
            this.tmrDragDrop = new System.Windows.Forms.Timer(this.components);
            this.pnlDrawingBoard = new KryptBit.PnlDoubleBuffer();
            this.msXbit.SuspendLayout();
            this.gbBitCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitCount)).BeginInit();
            this.pnlDrawContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // msXbit
            // 
            this.msXbit.Dock = System.Windows.Forms.DockStyle.None;
            this.msXbit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.msXbit.Location = new System.Drawing.Point(0, 0);
            this.msXbit.Name = "msXbit";
            this.msXbit.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msXbit.Size = new System.Drawing.Size(196, 28);
            this.msXbit.TabIndex = 7;
            this.msXbit.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.colorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.colorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmZero,
            this.tsmOne});
            this.bitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.bitToolStripMenuItem.Text = "Bit";
            // 
            // tsmZero
            // 
            this.tsmZero.BackColor = global::KryptBit.Properties.Settings.Default.Zero;
            this.tsmZero.Name = "tsmZero";
            this.tsmZero.Size = new System.Drawing.Size(86, 24);
            this.tsmZero.Text = "0";
            this.tsmZero.Click += new System.EventHandler(this.tsmZero_Click);
            // 
            // tsmOne
            // 
            this.tsmOne.BackColor = global::KryptBit.Properties.Settings.Default.One;
            this.tsmOne.Name = "tsmOne";
            this.tsmOne.Size = new System.Drawing.Size(86, 24);
            this.tsmOne.Text = "1";
            this.tsmOne.Click += new System.EventHandler(this.tsmOne_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.backgroundToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiAliasToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // antiAliasToolStripMenuItem
            // 
            this.antiAliasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.antiAliasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AAOn,
            this.AAOff});
            this.antiAliasToolStripMenuItem.Enabled = false;
            this.antiAliasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.antiAliasToolStripMenuItem.Name = "antiAliasToolStripMenuItem";
            this.antiAliasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.antiAliasToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.antiAliasToolStripMenuItem.Text = "AntiAlias";
            // 
            // AAOn
            // 
            this.AAOn.BackColor = System.Drawing.Color.Black;
            this.AAOn.ForeColor = System.Drawing.Color.White;
            this.AAOn.Name = "AAOn";
            this.AAOn.Size = new System.Drawing.Size(99, 24);
            this.AAOn.Text = "On";
            this.AAOn.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // AAOff
            // 
            this.AAOff.BackColor = System.Drawing.Color.Black;
            this.AAOff.ForeColor = System.Drawing.Color.White;
            this.AAOff.Name = "AAOff";
            this.AAOff.Size = new System.Drawing.Size(99, 24);
            this.AAOff.Text = "Off";
            this.AAOff.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryConverterToolStripMenuItem,
            this.createAFilterToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // binaryConverterToolStripMenuItem
            // 
            this.binaryConverterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.binaryConverterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.binaryConverterToolStripMenuItem.Name = "binaryConverterToolStripMenuItem";
            this.binaryConverterToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.binaryConverterToolStripMenuItem.Text = "Binary Converter";
            this.binaryConverterToolStripMenuItem.Click += new System.EventHandler(this.binaryConverterToolStripMenuItem_Click);
            // 
            // createAFilterToolStripMenuItem
            // 
            this.createAFilterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.createAFilterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createAFilterToolStripMenuItem.Name = "createAFilterToolStripMenuItem";
            this.createAFilterToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.createAFilterToolStripMenuItem.Text = "Create A Filter";
            // 
            // gbBitCount
            // 
            this.gbBitCount.Controls.Add(this.pbIcon);
            this.gbBitCount.Controls.Add(this.lblLoadData);
            this.gbBitCount.Controls.Add(this.txtBitCount);
            this.gbBitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBitCount.ForeColor = System.Drawing.Color.White;
            this.gbBitCount.Location = new System.Drawing.Point(22, 29);
            this.gbBitCount.Name = "gbBitCount";
            this.gbBitCount.Size = new System.Drawing.Size(174, 58);
            this.gbBitCount.TabIndex = 10;
            this.gbBitCount.TabStop = false;
            this.gbBitCount.Text = "Bit Count";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::KryptBit.Properties.Resources.FilterImage;
            this.pbIcon.InitialImage = global::KryptBit.Properties.Resources.FilterImage;
            this.pbIcon.Location = new System.Drawing.Point(134, 20);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(34, 34);
            this.pbIcon.TabIndex = 12;
            this.pbIcon.TabStop = false;
            this.ttHelpBot.SetToolTip(this.pbIcon, "Create Filter");
            this.pbIcon.Click += new System.EventHandler(this.pbIcon_Click);
            // 
            // lblLoadData
            // 
            this.lblLoadData.AutoSize = true;
            this.lblLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadData.Location = new System.Drawing.Point(104, 19);
            this.lblLoadData.Name = "lblLoadData";
            this.lblLoadData.Size = new System.Drawing.Size(24, 25);
            this.lblLoadData.TabIndex = 9;
            this.lblLoadData.Text = "+";
            this.ttHelpBot.SetToolTip(this.lblLoadData, "Choose Binary File");
            this.lblLoadData.Click += new System.EventHandler(this.lblLoadData_Click);
            // 
            // txtBitCount
            // 
            this.txtBitCount.AccessibleName = "txtBigCount";
            this.txtBitCount.Enabled = false;
            this.txtBitCount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtBitCount.Location = new System.Drawing.Point(6, 19);
            this.txtBitCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtBitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBitCount.Name = "txtBitCount";
            this.txtBitCount.Size = new System.Drawing.Size(68, 24);
            this.txtBitCount.TabIndex = 8;
            this.txtBitCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.txtBitCount.ValueChanged += new System.EventHandler(this.txtBitCount_ValueChanged);
            // 
            // vScrollbar
            // 
            this.vScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollbar.Location = new System.Drawing.Point(608, 0);
            this.vScrollbar.Name = "vScrollbar";
            this.vScrollbar.Size = new System.Drawing.Size(21, 574);
            this.vScrollbar.TabIndex = 14;
            this.vScrollbar.Visible = false;
            this.vScrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // tmrValueUpdater
            // 
            this.tmrValueUpdater.Interval = 1000;
            // 
            // pnlDrawContainer
            // 
            this.pnlDrawContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawContainer.Controls.Add(this.pnlDrawingBoard);
            this.pnlDrawContainer.Controls.Add(this.vScrollbar);
            this.pnlDrawContainer.Location = new System.Drawing.Point(22, 93);
            this.pnlDrawContainer.Name = "pnlDrawContainer";
            this.pnlDrawContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlDrawContainer.Size = new System.Drawing.Size(634, 569);
            this.pnlDrawContainer.TabIndex = 38;
            // 
            // cbFilterList
            // 
            this.cbFilterList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFilterList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.cbFilterList.BackColor = System.Drawing.Color.Black;
            this.cbFilterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterList.ForeColor = System.Drawing.Color.White;
            this.cbFilterList.FormattingEnabled = true;
            this.cbFilterList.Location = new System.Drawing.Point(202, 4);
            this.cbFilterList.MaxDropDownItems = 10;
            this.cbFilterList.Name = "cbFilterList";
            this.cbFilterList.Size = new System.Drawing.Size(193, 21);
            this.cbFilterList.Sorted = true;
            this.cbFilterList.TabIndex = 41;
            this.cbFilterList.Text = "Choose A Filter";
            this.cbFilterList.DropDown += new System.EventHandler(this.cbFilterList_DropDown);
            this.cbFilterList.SelectedIndexChanged += new System.EventHandler(this.cbFilterList_SelectedIndexChanged);
            this.cbFilterList.Click += new System.EventHandler(this.cbFilterList_Click_1);
            this.cbFilterList.Leave += new System.EventHandler(this.cbFilterList_Leave);
            // 
            // lblAddToStack
            // 
            this.lblAddToStack.AutoSize = true;
            this.lblAddToStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddToStack.ForeColor = System.Drawing.Color.White;
            this.lblAddToStack.Location = new System.Drawing.Point(398, 4);
            this.lblAddToStack.Name = "lblAddToStack";
            this.lblAddToStack.Size = new System.Drawing.Size(24, 25);
            this.lblAddToStack.TabIndex = 44;
            this.lblAddToStack.Text = "+";
            this.ttHelpBot.SetToolTip(this.lblAddToStack, "Add Filter");
            this.lblAddToStack.Click += new System.EventHandler(this.lblAddToStack_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ttHelpBot
            // 
            this.ttHelpBot.AutomaticDelay = 1000;
            this.ttHelpBot.AutoPopDelay = 1000;
            this.ttHelpBot.InitialDelay = 1000;
            this.ttHelpBot.IsBalloon = true;
            this.ttHelpBot.ReshowDelay = 200;
            // 
            // lstFilterStack
            // 
            this.lstFilterStack.BackColor = System.Drawing.Color.Black;
            this.lstFilterStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFilterStack.ForeColor = System.Drawing.Color.White;
            this.lstFilterStack.FormattingEnabled = true;
            this.lstFilterStack.Location = new System.Drawing.Point(202, 33);
            this.lstFilterStack.Name = "lstFilterStack";
            this.lstFilterStack.Size = new System.Drawing.Size(220, 54);
            this.lstFilterStack.TabIndex = 46;
            // 
            // tmrDragDrop
            // 
            this.tmrDragDrop.Enabled = true;
            this.tmrDragDrop.Interval = 10;
            this.tmrDragDrop.Tick += new System.EventHandler(this.tmrDragDrop_Tick);
            // 
            // pnlDrawingBoard
            // 
            this.pnlDrawingBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawingBoard.BackColor = global::KryptBit.Properties.Settings.Default.Background;
            this.pnlDrawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawingBoard.Location = new System.Drawing.Point(3, 3);
            this.pnlDrawingBoard.Name = "pnlDrawingBoard";
            this.pnlDrawingBoard.Size = new System.Drawing.Size(602, 559);
            this.pnlDrawingBoard.TabIndex = 13;
            this.pnlDrawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingBoard_Paint);
            this.pnlDrawingBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDrawingBoard_MouseClick_1);
            // 
            // frmKryptBit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::KryptBit.Properties.Settings.Default.Background;
            this.ClientSize = new System.Drawing.Size(658, 674);
            this.Controls.Add(this.lstFilterStack);
            this.Controls.Add(this.lblAddToStack);
            this.Controls.Add(this.cbFilterList);
            this.Controls.Add(this.pnlDrawContainer);
            this.Controls.Add(this.gbBitCount);
            this.Controls.Add(this.msXbit);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.msXbit;
            this.Name = "frmKryptBit";
            this.ShowIcon = false;
            this.Text = " Krypt Bit";
            this.Load += new System.EventHandler(this.frmKryptBit_Load);
            this.SizeChanged += new System.EventHandler(this.frmXBit_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmXBit_MouseClick);
            this.msXbit.ResumeLayout(false);
            this.msXbit.PerformLayout();
            this.gbBitCount.ResumeLayout(false);
            this.gbBitCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitCount)).EndInit();
            this.pnlDrawContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadData;
        private System.Windows.Forms.VScrollBar vScrollbar;
        private System.Windows.Forms.Timer tmrValueUpdater;
        public System.Windows.Forms.ToolStripMenuItem tsmZero;
        public System.Windows.Forms.ToolStripMenuItem tsmOne;
        public System.Windows.Forms.NumericUpDown txtBitCount;
        public System.Windows.Forms.ToolStripMenuItem AAOn;
        public System.Windows.Forms.ToolStripMenuItem AAOff;
        public System.Windows.Forms.MenuStrip msXbit;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem antiAliasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem binaryConverterToolStripMenuItem;
        public PnlDoubleBuffer pnlDrawingBoard;
        public System.Windows.Forms.GroupBox gbBitCount;
        public System.Windows.Forms.Panel pnlDrawContainer;
        public System.Windows.Forms.ComboBox cbFilterList;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblAddToStack;
        private System.Windows.Forms.ToolStripMenuItem createAFilterToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttHelpBot;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ListBox lstFilterStack;
        private System.Windows.Forms.Timer tmrDragDrop;
    }
}

