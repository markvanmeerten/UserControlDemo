﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class ListItemInstrument : UserControl
    {
        #region Properties
        
        private string _title;
        private string _description;
        private Image _image;

        public string Title
        {
            get { 
                return _title; 
            }

            set { 
                _title = value;
                lblTitle.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
                lblDescription.Text = value;
            }
        }

        public Image Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
                pbImage.Image = value;
            }
        }

        #endregion

        public delegate void ClickSomeWeirdButtonHandler(ListItemInstrument sender, EventArgs e);

        public event ClickSomeWeirdButtonHandler OnWeirdClick;
        public ListItemInstrument()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"[UserControl] You clicked on: {this.Title}");

            // Else return EventArgs.Empty();
            // Of: Cusom class die EventArgs extend
            EventArgs args = new EventArgs();

            // Call any listeners
            OnWeirdClick.Invoke(this, args);
        }
    }
}
