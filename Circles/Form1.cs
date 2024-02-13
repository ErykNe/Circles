using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        private Random randomColor = new Random();
        private Random randomVariable = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GenerateCirclesButton_Click(object sender, EventArgs e)
        {
            List<Circle> circles = new List<Circle>();
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.White);
            int amountOfCircles = Convert.ToInt32(amountTextBox.Text.Trim());
            label1.Text = amountOfCircles.ToString();

            for (int i = 0; i < amountOfCircles; i++)
            {
                Brush b = new SolidBrush(Color.FromArgb(randomColor.Next(0, 255), randomColor.Next(0, 255), randomColor.Next(0, 255)));

                Circle circle = new Circle();
                circle.x = randomVariable.Next(10, 730);
                circle.y = randomVariable.Next(10, 730);
                circle.radius = Convert.ToInt32(randomVariable.Next(3, 60));
                bool isCircleLegal = true;

                foreach (Circle existingCircle in circles)
                {
                    if (outsideButton.Checked && !outside(circle, existingCircle))
                    {
                        isCircleLegal = false;
                        break;
                    }
                    if (insideButton.Checked && !inside(circle, existingCircle) && !outside(circle, existingCircle))
                    {
                        isCircleLegal = false;
                        break;
                    }
                }

                if (isCircleLegal)
                {
                    circles.Add(circle);
                    g.FillEllipse(b, circle.x - circle.radius, circle.y - circle.radius, 2 * circle.radius, 2 * circle.radius);
                }
                else
                {
                    i--;
                }
            }
        }

        private bool outside(Circle circle1, Circle circle2)
        {
            double distance = Math.Sqrt(Math.Pow(circle1.x - circle2.x, 2) + Math.Pow(circle1.y - circle2.y, 2));
            return distance > (circle1.radius + circle2.radius);
        }

        private bool inside(Circle circle1, Circle circle2)
        {
            double distance = Math.Sqrt(Math.Pow(circle1.x - circle2.x, 2) + Math.Pow(circle1.y - circle2.y, 2));
            return distance + circle1.radius < circle2.radius;
        }
    }

    public class Circle
    {
        public int x;
        public int y;
        public int radius;
    }
}
