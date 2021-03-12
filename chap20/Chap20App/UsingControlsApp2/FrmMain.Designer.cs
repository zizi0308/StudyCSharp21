
namespace UsingControlsApp2
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrbHandle = new System.Windows.Forms.TrackBar();
            this.PrbDisplay = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnModal = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnMessageBox = new System.Windows.Forms.Button();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtResult);
            this.groupBox1.Controls.Add(this.ChkItalic);
            this.groupBox1.Controls.Add(this.ChkBold);
            this.groupBox1.Controls.Add(this.CboFont);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(8, 48);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(366, 21);
            this.TxtResult.TabIndex = 4;
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkItalic.Location = new System.Drawing.Point(312, 23);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(60, 16);
            this.ChkItalic.TabIndex = 3;
            this.ChkItalic.Text = "이텔릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkBold.Location = new System.Drawing.Point(258, 24);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 16);
            this.ChkBold.TabIndex = 2;
            this.ChkBold.Text = "굵게";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // CboFont
            // 
            this.CboFont.FormattingEnabled = true;
            this.CboFont.Location = new System.Drawing.Point(50, 20);
            this.CboFont.Name = "CboFont";
            this.CboFont.Size = new System.Drawing.Size(202, 20);
            this.CboFont.TabIndex = 1;
            this.CboFont.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrbHandle);
            this.groupBox2.Controls.Add(this.PrbDisplay);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TrackBar, ProgressBar";
            // 
            // TrbHandle
            // 
            this.TrbHandle.Location = new System.Drawing.Point(8, 22);
            this.TrbHandle.Maximum = 20;
            this.TrbHandle.Name = "TrbHandle";
            this.TrbHandle.Size = new System.Drawing.Size(362, 45);
            this.TrbHandle.TabIndex = 1;
            this.TrbHandle.Scroll += new System.EventHandler(this.TrbHandle_Scroll);
            // 
            // PrbDisplay
            // 
            this.PrbDisplay.Location = new System.Drawing.Point(6, 71);
            this.PrbDisplay.Maximum = 20;
            this.PrbDisplay.Name = "PrbDisplay";
            this.PrbDisplay.Size = new System.Drawing.Size(364, 27);
            this.PrbDisplay.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMessageBox);
            this.groupBox3.Controls.Add(this.BtnModaless);
            this.groupBox3.Controls.Add(this.BtnModal);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modal, Modaless";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnAddChild);
            this.groupBox4.Controls.Add(this.BtnAddRoot);
            this.groupBox4.Controls.Add(this.LsvDummy);
            this.groupBox4.Controls.Add(this.TrvDummy);
            this.groupBox4.Location = new System.Drawing.Point(13, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 265);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TreeView && ListView";
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(8, 32);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(107, 33);
            this.BtnModal.TabIndex = 0;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(141, 32);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(107, 33);
            this.BtnModaless.TabIndex = 1;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnMessageBox
            // 
            this.BtnMessageBox.Location = new System.Drawing.Point(267, 32);
            this.BtnMessageBox.Name = "BtnMessageBox";
            this.BtnMessageBox.Size = new System.Drawing.Size(107, 33);
            this.BtnMessageBox.TabIndex = 2;
            this.BtnMessageBox.Text = "MessageBox";
            this.BtnMessageBox.UseVisualStyleBackColor = true;
            this.BtnMessageBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(8, 20);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(184, 186);
            this.TrvDummy.TabIndex = 0;
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(201, 20);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(184, 186);
            this.LsvDummy.TabIndex = 1;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(8, 212);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(87, 38);
            this.BtnAddRoot.TabIndex = 2;
            this.BtnAddRoot.Text = "루트추가";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(105, 212);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(87, 38);
            this.BtnAddChild.TabIndex = 3;
            this.BtnAddChild.Text = "자식추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Using Control App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboFont;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar TrbHandle;
        private System.Windows.Forms.ProgressBar PrbDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnMessageBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
    }
}

