using System;

namespace PCView
{
    partial class Form
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
            this.groupBoxInfoUser = new System.Windows.Forms.GroupBox();
            this.labelResultUser = new System.Windows.Forms.Label();
            this.labelResultName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxInfoSystem = new System.Windows.Forms.GroupBox();
            this.labelResultVersionCLR = new System.Windows.Forms.Label();
            this.labelResultVersionSO = new System.Windows.Forms.Label();
            this.labelResultSPK = new System.Windows.Forms.Label();
            this.labelResultSys = new System.Windows.Forms.Label();
            this.labelVersionCLR = new System.Windows.Forms.Label();
            this.labelVersionSys = new System.Windows.Forms.Label();
            this.labelServicePack = new System.Windows.Forms.Label();
            this.labelSystem = new System.Windows.Forms.Label();
            this.groupBoxSoftList = new System.Windows.Forms.GroupBox();
            this.listBoxSoftware = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxInfoUser.SuspendLayout();
            this.groupBoxInfoSystem.SuspendLayout();
            this.groupBoxSoftList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfoUser
            // 
            this.groupBoxInfoUser.Controls.Add(this.labelResultUser);
            this.groupBoxInfoUser.Controls.Add(this.labelResultName);
            this.groupBoxInfoUser.Controls.Add(this.labelName);
            this.groupBoxInfoUser.Controls.Add(this.labelUser);
            this.groupBoxInfoUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfoUser.Name = "groupBoxInfoUser";
            this.groupBoxInfoUser.Size = new System.Drawing.Size(362, 89);
            this.groupBoxInfoUser.TabIndex = 0;
            this.groupBoxInfoUser.TabStop = false;
            this.groupBoxInfoUser.Text = "Informações do Usuário";
            // 
            // labelResultUser
            // 
            this.labelResultUser.AutoSize = true;
            this.labelResultUser.Location = new System.Drawing.Point(49, 56);
            this.labelResultUser.Name = "labelResultUser";
            this.labelResultUser.Size = new System.Drawing.Size(0, 13);
            this.labelResultUser.TabIndex = 3;
            // 
            // labelResultName
            // 
            this.labelResultName.AutoSize = true;
            this.labelResultName.Location = new System.Drawing.Point(40, 26);
            this.labelResultName.Name = "labelResultName";
            this.labelResultName.Size = new System.Drawing.Size(0, 13);
            this.labelResultName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(6, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 56);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Usuário:";
            // 
            // groupBoxInfoSystem
            // 
            this.groupBoxInfoSystem.Controls.Add(this.labelResultVersionCLR);
            this.groupBoxInfoSystem.Controls.Add(this.labelResultVersionSO);
            this.groupBoxInfoSystem.Controls.Add(this.labelResultSPK);
            this.groupBoxInfoSystem.Controls.Add(this.labelResultSys);
            this.groupBoxInfoSystem.Controls.Add(this.labelVersionCLR);
            this.groupBoxInfoSystem.Controls.Add(this.labelVersionSys);
            this.groupBoxInfoSystem.Controls.Add(this.labelServicePack);
            this.groupBoxInfoSystem.Controls.Add(this.labelSystem);
            this.groupBoxInfoSystem.Location = new System.Drawing.Point(12, 107);
            this.groupBoxInfoSystem.Name = "groupBoxInfoSystem";
            this.groupBoxInfoSystem.Size = new System.Drawing.Size(362, 127);
            this.groupBoxInfoSystem.TabIndex = 1;
            this.groupBoxInfoSystem.TabStop = false;
            this.groupBoxInfoSystem.Text = "Informações do Sitema";
            // 
            // labelResultVersionCLR
            // 
            this.labelResultVersionCLR.AutoSize = true;
            this.labelResultVersionCLR.Location = new System.Drawing.Point(71, 96);
            this.labelResultVersionCLR.Name = "labelResultVersionCLR";
            this.labelResultVersionCLR.Size = new System.Drawing.Size(0, 13);
            this.labelResultVersionCLR.TabIndex = 7;
            // 
            // labelResultVersionSO
            // 
            this.labelResultVersionSO.AutoSize = true;
            this.labelResultVersionSO.Location = new System.Drawing.Point(67, 73);
            this.labelResultVersionSO.Name = "labelResultVersionSO";
            this.labelResultVersionSO.Size = new System.Drawing.Size(0, 13);
            this.labelResultVersionSO.TabIndex = 6;
            // 
            // labelResultSPK
            // 
            this.labelResultSPK.AutoSize = true;
            this.labelResultSPK.Location = new System.Drawing.Point(86, 49);
            this.labelResultSPK.Name = "labelResultSPK";
            this.labelResultSPK.Size = new System.Drawing.Size(0, 13);
            this.labelResultSPK.TabIndex = 5;
            // 
            // labelResultSys
            // 
            this.labelResultSys.AutoSize = true;
            this.labelResultSys.Location = new System.Drawing.Point(111, 27);
            this.labelResultSys.Name = "labelResultSys";
            this.labelResultSys.Size = new System.Drawing.Size(0, 13);
            this.labelResultSys.TabIndex = 4;
            // 
            // labelVersionCLR
            // 
            this.labelVersionCLR.AutoSize = true;
            this.labelVersionCLR.Location = new System.Drawing.Point(6, 96);
            this.labelVersionCLR.Name = "labelVersionCLR";
            this.labelVersionCLR.Size = new System.Drawing.Size(67, 13);
            this.labelVersionCLR.TabIndex = 3;
            this.labelVersionCLR.Text = "Versão CLR:";
            // 
            // labelVersionSys
            // 
            this.labelVersionSys.AutoSize = true;
            this.labelVersionSys.Location = new System.Drawing.Point(6, 73);
            this.labelVersionSys.Name = "labelVersionSys";
            this.labelVersionSys.Size = new System.Drawing.Size(64, 13);
            this.labelVersionSys.TabIndex = 2;
            this.labelVersionSys.Text = "Versão S.O:";
            // 
            // labelServicePack
            // 
            this.labelServicePack.AutoSize = true;
            this.labelServicePack.Location = new System.Drawing.Point(6, 49);
            this.labelServicePack.Name = "labelServicePack";
            this.labelServicePack.Size = new System.Drawing.Size(74, 13);
            this.labelServicePack.TabIndex = 1;
            this.labelServicePack.Text = "Service Pack:";
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Location = new System.Drawing.Point(6, 27);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(107, 13);
            this.labelSystem.TabIndex = 0;
            this.labelSystem.Text = "Sistema Operacional:";
            // 
            // groupBoxSoftList
            // 
            this.groupBoxSoftList.Controls.Add(this.listBoxSoftware);
            this.groupBoxSoftList.Location = new System.Drawing.Point(13, 240);
            this.groupBoxSoftList.Name = "groupBoxSoftList";
            this.groupBoxSoftList.Size = new System.Drawing.Size(360, 246);
            this.groupBoxSoftList.TabIndex = 2;
            this.groupBoxSoftList.TabStop = false;
            this.groupBoxSoftList.Text = "Lista de Software";
            // 
            // listBoxSoftware
            // 
            this.listBoxSoftware.FormattingEnabled = true;
            this.listBoxSoftware.Location = new System.Drawing.Point(7, 20);
            this.listBoxSoftware.Name = "listBoxSoftware";
            this.listBoxSoftware.Size = new System.Drawing.Size(347, 212);
            this.listBoxSoftware.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(299, 510);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(218, 510);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 545);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxSoftList);
            this.Controls.Add(this.groupBoxInfoSystem);
            this.Controls.Add(this.groupBoxInfoUser);
            this.Name = "Form";
            this.Text = "PCView";
            this.groupBoxInfoUser.ResumeLayout(false);
            this.groupBoxInfoUser.PerformLayout();
            this.groupBoxInfoSystem.ResumeLayout(false);
            this.groupBoxInfoSystem.PerformLayout();
            this.groupBoxSoftList.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox groupBoxInfoUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxInfoSystem;
        private System.Windows.Forms.GroupBox groupBoxSoftList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelResultName;
        private System.Windows.Forms.Label labelSystem;

        #endregion

        private System.Windows.Forms.Label labelVersionCLR;
        private System.Windows.Forms.Label labelVersionSys;
        private System.Windows.Forms.Label labelServicePack;
        private System.Windows.Forms.Label labelResultUser;
        private System.Windows.Forms.Label labelResultSys;
        private System.Windows.Forms.Label labelResultSPK;
        private System.Windows.Forms.Label labelResultVersionSO;
        private System.Windows.Forms.Label labelResultVersionCLR;
        private System.Windows.Forms.ListBox listBoxSoftware;
    }
}

