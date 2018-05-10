namespace 한글패치병합
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_openfile = new System.Windows.Forms.Button();
            this.Btn_openfile2 = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.listView_origin = new System.Windows.Forms.ListView();
            this.listView_mod = new System.Windows.Forms.ListView();
            this.checkBox_backup = new System.Windows.Forms.CheckBox();
            this.checkBox_addlast = new System.Windows.Forms.CheckBox();
            this.button_exe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "원본 텍스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "추가/수정 텍스트";
            // 
            // Btn_openfile
            // 
            this.Btn_openfile.Location = new System.Drawing.Point(88, 8);
            this.Btn_openfile.Name = "Btn_openfile";
            this.Btn_openfile.Size = new System.Drawing.Size(321, 23);
            this.Btn_openfile.TabIndex = 2;
            this.Btn_openfile.Text = "클릭해서 원본 파일 선택";
            this.Btn_openfile.UseVisualStyleBackColor = true;
            this.Btn_openfile.Click += new System.EventHandler(this.Btn_openfile_Click);
            // 
            // Btn_openfile2
            // 
            this.Btn_openfile2.Location = new System.Drawing.Point(735, 8);
            this.Btn_openfile2.Name = "Btn_openfile2";
            this.Btn_openfile2.Size = new System.Drawing.Size(348, 23);
            this.Btn_openfile2.TabIndex = 3;
            this.Btn_openfile2.Text = "클릭해서 추가/수정할 파일 선택";
            this.Btn_openfile2.UseVisualStyleBackColor = true;
            this.Btn_openfile2.Click += new System.EventHandler(this.Btn_openfile2_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(1186, 41);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(110, 84);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "텍스트 확인";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // listView_origin
            // 
            this.listView_origin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView_origin.Location = new System.Drawing.Point(12, 41);
            this.listView_origin.Name = "listView_origin";
            this.listView_origin.Size = new System.Drawing.Size(643, 569);
            this.listView_origin.TabIndex = 7;
            this.listView_origin.UseCompatibleStateImageBehavior = false;
            this.listView_origin.View = System.Windows.Forms.View.Details;
            // 
            // listView_mod
            // 
            this.listView_mod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView_mod.Location = new System.Drawing.Point(661, 41);
            this.listView_mod.Name = "listView_mod";
            this.listView_mod.Size = new System.Drawing.Size(520, 569);
            this.listView_mod.TabIndex = 7;
            this.listView_mod.UseCompatibleStateImageBehavior = false;
            this.listView_mod.View = System.Windows.Forms.View.Details;
            // 
            // checkBox_backup
            // 
            this.checkBox_backup.AutoSize = true;
            this.checkBox_backup.Checked = true;
            this.checkBox_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_backup.Location = new System.Drawing.Point(1187, 249);
            this.checkBox_backup.Name = "checkBox_backup";
            this.checkBox_backup.Size = new System.Drawing.Size(76, 16);
            this.checkBox_backup.TabIndex = 8;
            this.checkBox_backup.Text = "원본 백업";
            this.checkBox_backup.UseVisualStyleBackColor = true;
            // 
            // checkBox_addlast
            // 
            this.checkBox_addlast.AutoSize = true;
            this.checkBox_addlast.Checked = true;
            this.checkBox_addlast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_addlast.Location = new System.Drawing.Point(1187, 215);
            this.checkBox_addlast.Name = "checkBox_addlast";
            this.checkBox_addlast.Size = new System.Drawing.Size(122, 28);
            this.checkBox_addlast.TabIndex = 9;
            this.checkBox_addlast.Text = "추가/수정 파일을 \r\n맨 뒤에 배치";
            this.checkBox_addlast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_addlast.UseVisualStyleBackColor = true;
            // 
            // button_exe
            // 
            this.button_exe.Location = new System.Drawing.Point(1187, 284);
            this.button_exe.Name = "button_exe";
            this.button_exe.Size = new System.Drawing.Size(110, 88);
            this.button_exe.TabIndex = 10;
            this.button_exe.Text = "병합";
            this.button_exe.UseVisualStyleBackColor = true;
            this.button_exe.Click += new System.EventHandler(this.button_exe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 622);
            this.Controls.Add(this.button_exe);
            this.Controls.Add(this.checkBox_addlast);
            this.Controls.Add(this.checkBox_backup);
            this.Controls.Add(this.listView_mod);
            this.Controls.Add(this.listView_origin);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.Btn_openfile2);
            this.Controls.Add(this.Btn_openfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "_AutoGeneratedTranslations.ko 병합기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_openfile;
        private System.Windows.Forms.Button Btn_openfile2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListView listView_origin;
        private System.Windows.Forms.ListView listView_mod;
        private System.Windows.Forms.CheckBox checkBox_addlast;
        private System.Windows.Forms.CheckBox checkBox_backup;
        private System.Windows.Forms.Button button_exe;
    }
}

