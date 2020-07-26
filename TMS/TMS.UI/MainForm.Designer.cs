﻿namespace TMS.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.appointmentsNotificationBadge = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnInvoices = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAppointments = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClients = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // appointmentsNotificationBadge
            // 
            this.appointmentsNotificationBadge.CheckedState.Parent = this.appointmentsNotificationBadge;
            this.appointmentsNotificationBadge.CustomImages.Parent = this.appointmentsNotificationBadge;
            this.appointmentsNotificationBadge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.appointmentsNotificationBadge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsNotificationBadge.ForeColor = System.Drawing.Color.Red;
            this.appointmentsNotificationBadge.HoverState.Parent = this.appointmentsNotificationBadge;
            this.appointmentsNotificationBadge.Location = new System.Drawing.Point(547, 5);
            this.appointmentsNotificationBadge.Name = "appointmentsNotificationBadge";
            this.appointmentsNotificationBadge.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.appointmentsNotificationBadge.ShadowDecoration.Parent = this.appointmentsNotificationBadge;
            this.appointmentsNotificationBadge.Size = new System.Drawing.Size(23, 24);
            this.appointmentsNotificationBadge.TabIndex = 7;
            this.appointmentsNotificationBadge.Text = "0";
            this.appointmentsNotificationBadge.Click += new System.EventHandler(this.AppointmentsNotificationBadge_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackgroundImage = global::TMS.UI.Properties.Resources.bill;
            this.btnInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoices.CheckedState.Parent = this.btnInvoices;
            this.btnInvoices.HoverState.Parent = this.btnInvoices;
            this.btnInvoices.Location = new System.Drawing.Point(383, 12);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.PressedState.Parent = this.btnInvoices;
            this.btnInvoices.Size = new System.Drawing.Size(147, 134);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppointments.BackgroundImage")));
            this.btnAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppointments.CheckedState.Parent = this.btnAppointments;
            this.btnAppointments.HoverState.Parent = this.btnAppointments;
            this.btnAppointments.Location = new System.Drawing.Point(203, 12);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.PressedState.Parent = this.btnAppointments;
            this.btnAppointments.Size = new System.Drawing.Size(147, 134);
            this.btnAppointments.TabIndex = 5;
            this.btnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClients.BackgroundImage")));
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClients.CheckedState.Parent = this.btnClients;
            this.btnClients.HoverState.Parent = this.btnClients;
            this.btnClients.Location = new System.Drawing.Point(23, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.PressedState.Parent = this.btnClients;
            this.btnClients.Size = new System.Drawing.Size(147, 134);
            this.btnClients.TabIndex = 4;
            this.btnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 158);
            this.Controls.Add(this.appointmentsNotificationBadge);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS - Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnClients;
        private Guna.UI2.WinForms.Guna2ImageButton btnAppointments;
        private Guna.UI2.WinForms.Guna2ImageButton btnInvoices;
        private Guna.UI2.WinForms.Guna2CircleButton appointmentsNotificationBadge;
    }
}

