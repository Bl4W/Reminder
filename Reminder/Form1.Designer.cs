namespace Reminder
{
    partial class Form_Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.btn_saveNotifi = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.btn_shutDown = new System.Windows.Forms.Button();
            this.btn_minimalize = new System.Windows.Forms.Button();
            this.lbl_list = new System.Windows.Forms.Label();
            this.list_notifications = new System.Windows.Forms.ListView();
            this.btn_delteNotifi = new System.Windows.Forms.Button();
            this.notifiIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tb_infoNotifi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_interval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_saveNotifi
            // 
            this.btn_saveNotifi.Location = new System.Drawing.Point(354, 109);
            this.btn_saveNotifi.Name = "btn_saveNotifi";
            this.btn_saveNotifi.Size = new System.Drawing.Size(81, 77);
            this.btn_saveNotifi.TabIndex = 1;
            this.btn_saveNotifi.Text = "Uložit upozornění";
            this.btn_saveNotifi.UseVisualStyleBackColor = true;
            this.btn_saveNotifi.Click += new System.EventHandler(this.btn_saveNotifi_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd MM yyyy - HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(160, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.Location = new System.Drawing.Point(12, 18);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(115, 13);
            this.lbl_dateTime.TabIndex = 2;
            this.lbl_dateTime.Text = "Výběr data upozornění";
            // 
            // btn_shutDown
            // 
            this.btn_shutDown.Location = new System.Drawing.Point(354, 295);
            this.btn_shutDown.Name = "btn_shutDown";
            this.btn_shutDown.Size = new System.Drawing.Size(81, 34);
            this.btn_shutDown.TabIndex = 5;
            this.btn_shutDown.Text = "Vypnout";
            this.btn_shutDown.UseVisualStyleBackColor = true;
            this.btn_shutDown.Click += new System.EventHandler(this.btn_shutDown_Click);
            // 
            // btn_minimalize
            // 
            this.btn_minimalize.Location = new System.Drawing.Point(354, 255);
            this.btn_minimalize.Name = "btn_minimalize";
            this.btn_minimalize.Size = new System.Drawing.Size(81, 34);
            this.btn_minimalize.TabIndex = 4;
            this.btn_minimalize.Text = "Minimalizovat na pozadí";
            this.btn_minimalize.UseVisualStyleBackColor = true;
            this.btn_minimalize.Click += new System.EventHandler(this.btn_minimalize_Click);
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(12, 199);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(150, 13);
            this.lbl_list.TabIndex = 5;
            this.lbl_list.Text = "Seznam aktivních upozornění";
            // 
            // list_notifications
            // 
            this.list_notifications.Location = new System.Drawing.Point(15, 215);
            this.list_notifications.MultiSelect = false;
            this.list_notifications.Name = "list_notifications";
            this.list_notifications.Size = new System.Drawing.Size(333, 114);
            this.list_notifications.TabIndex = 2;
            this.list_notifications.UseCompatibleStateImageBehavior = false;
            this.list_notifications.View = System.Windows.Forms.View.List;
            // 
            // btn_delteNotifi
            // 
            this.btn_delteNotifi.Location = new System.Drawing.Point(354, 215);
            this.btn_delteNotifi.Name = "btn_delteNotifi";
            this.btn_delteNotifi.Size = new System.Drawing.Size(81, 34);
            this.btn_delteNotifi.TabIndex = 3;
            this.btn_delteNotifi.Text = "Smazat upozornění";
            this.btn_delteNotifi.UseVisualStyleBackColor = true;
            this.btn_delteNotifi.Click += new System.EventHandler(this.btn_delteNotifi_Click);
            // 
            // notifiIcon
            // 
            this.notifiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifiIcon.Icon")));
            this.notifiIcon.Text = "Reminder";
            this.notifiIcon.Visible = true;
            this.notifiIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifiIcon_MouseDoubleClick);
            // 
            // tb_infoNotifi
            // 
            this.tb_infoNotifi.Location = new System.Drawing.Point(15, 109);
            this.tb_infoNotifi.MaxLength = 500;
            this.tb_infoNotifi.Multiline = true;
            this.tb_infoNotifi.Name = "tb_infoNotifi";
            this.tb_infoNotifi.Size = new System.Drawing.Size(333, 77);
            this.tb_infoNotifi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informace o upozornění";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Interval opakování (min)";
            // 
            // num_interval
            // 
            this.num_interval.Location = new System.Drawing.Point(160, 51);
            this.num_interval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_interval.Name = "num_interval";
            this.num_interval.Size = new System.Drawing.Size(51, 20);
            this.num_interval.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "0 - bez opakování";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_infoNotifi);
            this.Controls.Add(this.btn_delteNotifi);
            this.Controls.Add(this.list_notifications);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.btn_minimalize);
            this.Controls.Add(this.btn_shutDown);
            this.Controls.Add(this.lbl_dateTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_saveNotifi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNotifi;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Button btn_shutDown;
        private System.Windows.Forms.Button btn_minimalize;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.ListView list_notifications;
        private System.Windows.Forms.Button btn_delteNotifi;
        private System.Windows.Forms.NotifyIcon notifiIcon;
        private System.Windows.Forms.TextBox tb_infoNotifi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_interval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
    }
}

