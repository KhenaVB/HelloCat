namespace helloui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            moesiz_Button = new Button();
            kekw = new Label();
            veel_gram_textbox = new TextBox();
            textbutton = new Button();
            resultaatgram_label = new Label();
            SuspendLayout();
            // 
            // moesiz_Button
            // 
            moesiz_Button.BackColor = Color.IndianRed;
            moesiz_Button.Location = new Point(313, 160);
            moesiz_Button.Name = "moesiz_Button";
            moesiz_Button.Size = new Size(163, 85);
            moesiz_Button.TabIndex = 0;
            moesiz_Button.Text = "moesiz";
            moesiz_Button.UseVisualStyleBackColor = false;
            moesiz_Button.Click += moesiz_Button_Click;
            // 
            // kekw
            // 
            kekw.AutoSize = true;
            kekw.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            kekw.Location = new Point(333, 90);
            kekw.Name = "kekw";
            kekw.Size = new Size(111, 67);
            kekw.TabIndex = 1;
            kekw.Text = "Kek";
            kekw.Visible = false;
            // 
            // veel_gram_textbox
            // 
            veel_gram_textbox.Location = new Point(12, 245);
            veel_gram_textbox.Name = "veel_gram_textbox";
            veel_gram_textbox.Size = new Size(776, 23);
            veel_gram_textbox.TabIndex = 2;
            veel_gram_textbox.TextChanged += veel_gram_textbox_TextChanged;
            // 
            // textbutton
            // 
            textbutton.Location = new Point(231, 305);
            textbutton.Name = "textbutton";
            textbutton.Size = new Size(332, 55);
            textbutton.TabIndex = 3;
            textbutton.Text = "gram?";
            textbutton.UseVisualStyleBackColor = true;
            textbutton.Click += textbutton_Click;
            // 
            // resultaatgram_label
            // 
            resultaatgram_label.AutoSize = true;
            resultaatgram_label.Location = new Point(613, 323);
            resultaatgram_label.Name = "resultaatgram_label";
            resultaatgram_label.Size = new Size(61, 15);
            resultaatgram_label.TabIndex = 4;
            resultaatgram_label.Text = "qzdqzgfqz";
            resultaatgram_label.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultaatgram_label);
            Controls.Add(textbutton);
            Controls.Add(veel_gram_textbox);
            Controls.Add(kekw);
            Controls.Add(moesiz_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button moesiz_Button;
        private Label kekw;
        private TextBox veel_gram_textbox;
        private Button textbutton;
        private Label resultaatgram_label;
    }
}