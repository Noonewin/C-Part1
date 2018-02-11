using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11
{
    public partial class Assessment11 : Form
    {
        //setting up constants.
        const int SIZE = 50;
        Experiment[] Experiments = new Experiment[SIZE];
        Dictionary<int, Experiment> listBoxItems = new Dictionary<int, Experiment>();
        Experiment expTmp;
        public Assessment11()
        {
            InitializeComponent();
            combBoxColor.DataSource = new string[] { "", "Crimson", "Azure", "Taupe", "Mauve", "Vermillion", "Chartreuse" };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Validates input.
            if (validation())
            {
                //Conditions for overloaded constructor.
                if (txtBoxName.Text != "" && txtBoxExpNumb.Text == "" && txtBoxExpDescrp.Text == "" && txtBoxResultVolume.Text == "" && txtBoxResultWeight.Text == "" && combBoxColor.Text == "")
                {
                    Experiment exp = new Experiment(txtBoxName.Text);
                    expTmp = exp;
                }
                else if (txtBoxName.Text == "" && txtBoxExpNumb.Text != "" && txtBoxExpDescrp.Text != "" && txtBoxResultVolume.Text == "" && txtBoxResultWeight.Text == "" && combBoxColor.Text == "")
                {
                    Experiment exp = new Experiment(Int32.Parse(txtBoxExpNumb.Text), txtBoxExpDescrp.Text);
                    expTmp = exp;
                }
                else
                {
                    Experiment exp = new Experiment();
                    expTmp = exp;
                }
                
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes current form.
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Checks if all fields are completed.
            if (checkAllFields())
            {
                //Checks if there is a object in the array with the same index.
                if (Experiments[expTmp.experimentNumber - 1] == null)
                {
                    Experiments[expTmp.experimentNumber - 1] = expTmp;
                    listBoxSummary.Items.Add(String.Format("{0}\t{1}", expTmp.experimentNumber, expTmp.experimentDescription));
                }
                else
                {
                    MessageBox.Show("There is a record with that number. Please try another one.");
                }

            }else
            {
                MessageBox.Show("You have not entered all fields. In order to SAVE a record you must complete all fields.");
            }
            //Checks if all 50 places in the array are taken. Disables buttons.
            checkArray();


        }

        //Checks if all attributes of the object are changed.
        private bool checkAllFields()
        {
            try
            {
                if (expTmp.Name != "" && expTmp.experimentNumber != Int32.MinValue && expTmp.experimentDescription != "" &&
                expTmp.volume != Double.MinValue && expTmp.weight != Double.MinValue && expTmp.color != "")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
            
        }

        //Validates user input and returns status.
        private bool validation()
        {
            if (txtBoxExpNumb.Text !="")
            {
                try
                {
                    int number = Int32.Parse(txtBoxExpNumb.Text);
                    if(number < 1 || number > 50)
                    {
                        MessageBox.Show("Experiment number must be between 1 and 50.");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("There is a problem with your experiment number.");
                    return false;
                }
            }
            if (txtBoxResultWeight.Text != "")
            {
                try
                {
                    double number = Convert.ToDouble(txtBoxResultWeight.Text);
                }
                catch
                {
                    MessageBox.Show("There is a problem with your weight number.");
                    return false;
                }
            }
            if (txtBoxResultVolume.Text != "")
            {
                try
                {
                    double number = Convert.ToDouble(txtBoxResultVolume.Text);
                }
                catch
                {
                    MessageBox.Show("There is a problem with your volume number.");
                    return false;
                }
            }
            return true;
        }

        //Updates values of the object attributes.
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                addData();
            }

        }

        //Updates values of the object attributes.
        private void addData()
        {
            if (txtBoxName.Text != "")
            {
                expTmp.Name = txtBoxName.Text;
            }
            if (txtBoxExpDescrp.Text != "")
            {
                expTmp.experimentDescription = txtBoxExpDescrp.Text;
            }
            if (txtBoxExpNumb.Text != "")
            {
                expTmp.experimentNumber = Int32.Parse(txtBoxExpNumb.Text);
            }
            if (txtBoxResultWeight.Text != "")
            {
                expTmp.weight = Convert.ToDouble(txtBoxResultWeight.Text);
            }
            if (txtBoxResultVolume.Text != "")
            {
                expTmp.volume = Convert.ToDouble(txtBoxResultVolume.Text);
            }
            if (combBoxColor.Text != "")
            {
                expTmp.color = combBoxColor.Text;
            }
        }


        //Shows form with summery of the attributes in the selected record.
        private void listBoxSummary_DoubleClick(object sender, EventArgs e)
        {
            int index = Int32.Parse(listBoxSummary.SelectedItem.ToString().Split('\t')[0]);
            Review myReviewForm = new Review();

            //Set values for the public property
            myReviewForm.txtBoxName.Text = Experiments[index-1].Name;
            myReviewForm.txtBoxExpNumb.Text = Convert.ToString(Experiments[index - 1].experimentNumber);
            myReviewForm.txtBoxExpDescrp.Text = Experiments[index - 1].experimentDescription;
            myReviewForm.txtBoxResultWeight.Text = Convert.ToString(Experiments[index - 1].weight);
            myReviewForm.txtBoxColor.Text = Experiments[index - 1].color;
            myReviewForm.txtBoxResultVolume.Text = Convert.ToString(Experiments[index-1].volume);


            //Display the form modally
            myReviewForm.ShowDialog();
        }

        //Resets all values in the form.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxExpDescrp.Text = "";
            txtBoxExpNumb.Text = "";
            txtBoxResultVolume.Text = "";
            txtBoxResultWeight.Text = "";
            combBoxColor.Text = "";
            Experiment[] Experiments = new Experiment[SIZE];
            Dictionary<int, Experiment> listBoxItems = new Dictionary<int, Experiment>();
            Experiment expTmp;
            listBoxSummary.Items.Clear();
        }


        //Checks if all 50 place holders of the array are filled. Return status.
        private void checkArray()
        {
            bool status = true;
            for (int i = 0; i < Experiments.Length; i++)
            {
                if (Experiments[i] == null)
                {
                    status = false;
                }
            }
            if (status)
            {
                btnCreate.Enabled = false;
                btnSet.Enabled = false;
                btnSave.Enabled = false;
            }
        }
    }
}
