
namespace TechProgramming
{
    partial class FormCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.pictureBoxCars = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(8, 8);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 1;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonUp
            // 
            this.ButtonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUp.BackgroundImage = global::TechProgramming.Properties.Resources.upp;
            this.ButtonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUp.Location = new System.Drawing.Point(781, 286);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(30, 30);
            this.ButtonUp.TabIndex = 5;
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLeft.BackgroundImage = global::TechProgramming.Properties.Resources.left2;
            this.ButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLeft.Location = new System.Drawing.Point(745, 322);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(30, 30);
            this.ButtonLeft.TabIndex = 4;
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDown.BackgroundImage = global::TechProgramming.Properties.Resources.down1;
            this.ButtonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDown.Location = new System.Drawing.Point(781, 322);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(30, 30);
            this.ButtonDown.TabIndex = 3;
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRight.BackgroundImage")));
            this.ButtonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRight.Location = new System.Drawing.Point(817, 322);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(30, 30);
            this.ButtonRight.TabIndex = 2;
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxCars
            // 
            this.pictureBoxCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCars.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCars.Name = "pictureBoxCars";
            this.pictureBoxCars.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxCars.TabIndex = 0;
            this.pictureBoxCars.TabStop = false;
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.pictureBoxCars);
            this.Name = "FormCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCars;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonUp;
    }
}

