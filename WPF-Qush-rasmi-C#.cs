using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
namespace Lab18_Qush
{
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			Line tumshuq1=new Line
			{
				X1=45,
				Y1=40,
				X2=80,
				Y2=20,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(tumshuq1);
			Line tumshuq2=new Line
			{
				X1=45,
				Y1=40,
				X2=80,
				Y2=40,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(tumshuq2);
			Line tumshuq3=new Line
			{
				X1=80,
				Y1=20,
				X2=80,
				Y2=40,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(tumshuq3);
			
			Line buyin1=new Line
			{
				X1=85,
				Y1=15,
				X2=85,
				Y2=104,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(buyin1);
			
			Line buyin2=new Line
			{
				X1=142,
				Y1=60,
				X2=85,
				Y2=104,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(buyin2);
			
			Line buyin3=new Line
			{
				X1=142,
				Y1=60,
				X2=85,
				Y2=15,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(buyin3);
			
			Line qanot1=new Line
			{
				X1=90,
				Y1=110,
				X2=200,
				Y2=20,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(qanot1);
			
			Line qanot2=new Line
			{
				X1=200,
				Y1=20,
				X2=305,
				Y2=20,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(qanot2);
			
			Line qanot3=new Line
			{
				X1=305,
				Y1=20,
				X2=140,
				Y2=160,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(qanot3);
			
			Line qanot4=new Line
			{
				X1=140,
				Y1=160,
				X2=90,
				Y2=110,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(qanot4);
			
			Line dum1=new Line
			{
				X1=145,
				Y1=165,
				X2=200,
				Y2=117,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(dum1);
			
			Line dum2=new Line
			{
				X1=200,
				Y1=117,
				X2=200,
				Y2=210,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(dum2);
			
			Line dum3=new Line
			{
				X1=200,
				Y1=210,
				X2=145,
				Y2=165,
				Stroke=Brushes.Black,
				StrokeThickness=3,
			};
			canvas1.Children.Add(dum3);
		}
		
	}
}