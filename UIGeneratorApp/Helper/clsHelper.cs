using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace UIGeneratorApp.Helper
{

    public class Person
    {
        public int Age { get; set; }    
        public string Name { get; set; }
        public bool IsEmployee {  get; set; }
      
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public decimal Salary {  get; set; }

      
    }
    public class Order
    {
        public string OrderNumber { get; set; }

        public string OrderName { get; set; }   

        public DateTime DateDate { get; set; }

      
    }

    public static class clsHelper
    {


        /*
         * Properties:
                    Property Name: test0, Type: System.Int32
                    Property Name: test1, Type: System.Boolean
                    Property Name: test2, Type: System.String
                    Property Name: test3, Type: System.Decimal
                    Property Name: test4, Type: System.Single
                    Property Name: test5, Type: System.Double
                    Property Name: test6, Type: System.Byte
                    Property Name: test7, Type: System.DateTime
         */

     
        public static TextBox GenerateTextBox(int X,int Y)
        {
            TextBox textBox = new TextBox();
           
            textBox.Size = new System.Drawing.Size(150, 20);
            textBox.Location = new System.Drawing.Point(X, Y);

            return textBox;
        }

        public static RadioButton GenerateRadio(int X, int Y,string Text)
        {
           RadioButton radioButton = new RadioButton();
            radioButton.Text = Text;
         
            radioButton.Location= new System.Drawing.Point(X,Y);

            return radioButton;
        }

        public static Label GenerateLabel(int X, int Y,string Text)
        {
            Label label = new Label();
            label.Text = Text;
            label.Location = new System.Drawing.Point(X,Y);
            return label;
        }

        public static NumericUpDown GenerateNumericUpDown(int X, int Y)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Location = new System.Drawing.Point(X, Y);

            return numericUpDown;
        }

        public static DateTimePicker GenerateDateTimePicker(int X, int Y)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();

            dateTimePicker.Location = new System.Drawing.Point(X, Y);
          
            return dateTimePicker;
        }

        public static Panel PaintUI(PropertyInfo[] propertyInfo)
        {
            Panel pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Left;
            pnlContainer.Width = 650;
            int X = 100, Y = 60;

            foreach(PropertyInfo property in propertyInfo)
            {
                switch (property.PropertyType.ToString())
                {
                    case "System.Int32":
                        pnlContainer.Controls.Add(GenerateNumericUpDown(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                        break;
                    case "System.Boolean":
                        pnlContainer.Controls.Add(GenerateRadio(X, Y, $"{property.Name.ToString()}: "));
                        pnlContainer.Controls.Add(GenerateRadio(X+150, Y, "Other"));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                       
                        break;
                    case "System.String":
                        pnlContainer.Controls.Add(GenerateTextBox(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                       
                        break;
                    case "System.Decimal":
                        pnlContainer.Controls.Add(GenerateTextBox(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                        
                        break;
                    case "System.Single":
                        pnlContainer.Controls.Add(GenerateTextBox(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                       
                        break;
                    case "System.Double":
                        pnlContainer.Controls.Add(GenerateTextBox(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                       
                        break;
                    case "System.Byte":
                        pnlContainer.Controls.Add(GenerateTextBox(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                        
                        break;
                    case "System.DateTime":
                        pnlContainer.Controls.Add(GenerateDateTimePicker(X, Y));
                        pnlContainer.Controls.Add(GenerateLabel(X - 90, Y, $"{property.Name.ToString()}: "));
                       
                        break;
                      default:
                        break;
                }
                Y += 30;
            }
            return pnlContainer;
        }
    }
}
