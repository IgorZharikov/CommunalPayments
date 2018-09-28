namespace CommunalPayments
{
    partial class fmApartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSquare = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResidents = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbSquare.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResidents.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь помещения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Прописано человек:";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbAddress.Location = new System.Drawing.Point(170, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(371, 23);
            this.tbAddress.TabIndex = 3;
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(170, 35);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSquare.Properties.Appearance.Options.UseFont = true;
            this.tbSquare.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tbSquare.Properties.Mask.EditMask = "###.##";
            this.tbSquare.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbSquare.Size = new System.Drawing.Size(68, 22);
            this.tbSquare.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(244, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "кв.м.";
            // 
            // tbResidents
            // 
            this.tbResidents.Location = new System.Drawing.Point(170, 63);
            this.tbResidents.Name = "tbResidents";
            this.tbResidents.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbResidents.Properties.Appearance.Options.UseFont = true;
            this.tbResidents.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tbResidents.Properties.Mask.EditMask = "f0";
            this.tbResidents.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbResidents.Size = new System.Drawing.Size(68, 22);
            this.tbResidents.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CommunalPayments.Properties.Resources.save_32x32;
            this.btnSave.Location = new System.Drawing.Point(416, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fmApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 100);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbResidents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSquare);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка объекта недвижимости";
            ((System.ComponentModel.ISupportInitialize)(this.tbSquare.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResidents.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private DevExpress.XtraEditors.TextEdit tbSquare;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tbResidents;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}