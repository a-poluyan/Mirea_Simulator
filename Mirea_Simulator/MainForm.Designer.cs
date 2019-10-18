namespace Mirea_Simulator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.picMireaGerb = new System.Windows.Forms.PictureBox();
            this.picMireaLogo = new System.Windows.Forms.PictureBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTtd = new System.Windows.Forms.Button();
            this.btnTesting = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbChooseCommutator = new System.Windows.Forms.Label();
            this.cbChooseCommutator = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.picCommutator = new System.Windows.Forms.PictureBox();
            this.btnWebTesting = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMireaGerb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMireaLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCommutator)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.Controls.Add(this.picMireaGerb, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.picMireaLogo, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbInfo, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 420);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 142);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // picMireaGerb
            // 
            this.picMireaGerb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMireaGerb.Image = ((System.Drawing.Image)(resources.GetObject("picMireaGerb.Image")));
            this.picMireaGerb.Location = new System.Drawing.Point(11, 3);
            this.picMireaGerb.MaximumSize = new System.Drawing.Size(300, 300);
            this.picMireaGerb.Name = "picMireaGerb";
            this.picMireaGerb.Size = new System.Drawing.Size(182, 126);
            this.picMireaGerb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMireaGerb.TabIndex = 1;
            this.picMireaGerb.TabStop = false;
            // 
            // picMireaLogo
            // 
            this.picMireaLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMireaLogo.Image = ((System.Drawing.Image)(resources.GetObject("picMireaLogo.Image")));
            this.picMireaLogo.Location = new System.Drawing.Point(388, 3);
            this.picMireaLogo.MaximumSize = new System.Drawing.Size(300, 300);
            this.picMireaLogo.Name = "picMireaLogo";
            this.picMireaLogo.Size = new System.Drawing.Size(182, 126);
            this.picMireaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMireaLogo.TabIndex = 0;
            this.picMireaLogo.TabStop = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.Location = new System.Drawing.Point(201, 113);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(179, 19);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "ВУЦ РТУ МИРЭА";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lbHeader, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.91549F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 90);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoEllipsis = true;
            this.lbHeader.AutoSize = true;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.Location = new System.Drawing.Point(13, 12);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(558, 78);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Обучающая программа по симулированию работы с аппаратурой связи";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Controls.Add(this.btnWebTesting, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTtd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTesting, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTraining, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 368);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.4058F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnTtd
            // 
            this.btnTtd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTtd.Enabled = false;
            this.btnTtd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTtd.Location = new System.Drawing.Point(23, 3);
            this.btnTtd.Name = "btnTtd";
            this.btnTtd.Size = new System.Drawing.Size(122, 39);
            this.btnTtd.TabIndex = 0;
            this.btnTtd.Text = "ТТД";
            this.btnTtd.UseVisualStyleBackColor = true;
            this.btnTtd.Click += new System.EventHandler(this.btnTtd_Click);
            // 
            // btnTesting
            // 
            this.btnTesting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTesting.Enabled = false;
            this.btnTesting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTesting.Location = new System.Drawing.Point(299, 3);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(122, 39);
            this.btnTesting.TabIndex = 2;
            this.btnTesting.Text = "Контроль";
            this.btnTesting.UseVisualStyleBackColor = true;
            // 
            // btnTraining
            // 
            this.btnTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraining.Enabled = false;
            this.btnTraining.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTraining.Location = new System.Drawing.Point(161, 3);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(122, 39);
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Text = "Обучение";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel4.Controls.Add(this.lbChooseCommutator, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbChooseCommutator, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(584, 86);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lbChooseCommutator
            // 
            this.lbChooseCommutator.AutoSize = true;
            this.lbChooseCommutator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbChooseCommutator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChooseCommutator.Location = new System.Drawing.Point(174, 18);
            this.lbChooseCommutator.Name = "lbChooseCommutator";
            this.lbChooseCommutator.Size = new System.Drawing.Size(234, 21);
            this.lbChooseCommutator.TabIndex = 0;
            this.lbChooseCommutator.Text = "Выберите аппаратуру:";
            this.lbChooseCommutator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChooseCommutator
            // 
            this.cbChooseCommutator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbChooseCommutator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseCommutator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbChooseCommutator.FormattingEnabled = true;
            this.cbChooseCommutator.Items.AddRange(new object[] {
            "П-302"});
            this.cbChooseCommutator.Location = new System.Drawing.Point(183, 50);
            this.cbChooseCommutator.Name = "cbChooseCommutator";
            this.cbChooseCommutator.Size = new System.Drawing.Size(216, 29);
            this.cbChooseCommutator.TabIndex = 1;
            this.cbChooseCommutator.SelectedIndexChanged += new System.EventHandler(this.cbChooseCommutator_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.picCommutator, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(584, 192);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // picCommutator
            // 
            this.picCommutator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCommutator.Location = new System.Drawing.Point(23, 13);
            this.picCommutator.Name = "picCommutator";
            this.picCommutator.Size = new System.Drawing.Size(538, 166);
            this.picCommutator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCommutator.TabIndex = 0;
            this.picCommutator.TabStop = false;
            // 
            // btnWebTesting
            // 
            this.btnWebTesting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWebTesting.Enabled = false;
            this.btnWebTesting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnWebTesting.Location = new System.Drawing.Point(437, 3);
            this.btnWebTesting.Name = "btnWebTesting";
            this.btnWebTesting.Size = new System.Drawing.Size(121, 39);
            this.btnWebTesting.TabIndex = 3;
            this.btnWebTesting.Text = "Тестирование";
            this.btnWebTesting.UseVisualStyleBackColor = true;
            this.btnWebTesting.Click += new System.EventHandler(this.btnWebTesting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Text = "ВУЦ РТУ МИРЭА";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMireaGerb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMireaLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCommutator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox picMireaLogo;
        private System.Windows.Forms.PictureBox picMireaGerb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTtd;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbChooseCommutator;
        private System.Windows.Forms.ComboBox cbChooseCommutator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.PictureBox picCommutator;
        private System.Windows.Forms.Button btnWebTesting;
    }
}

