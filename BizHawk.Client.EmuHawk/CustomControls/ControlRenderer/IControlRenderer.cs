﻿using System;
using System.Drawing;

namespace BizHawk.Client.EmuHawk.CustomControls
{
	public interface IControlRenderer : IDisposable
	{
		/// <summary>
		/// Required to use before calling drawing methods
		/// </summary>
		IDisposable LockGraphics(Graphics g);

		void StartOffScreenBitmap(int width, int height);
		void EndOffScreenBitmap();
		void CopyToScreen();

		/// <summary>
		/// Measure the width and height of string <paramref name="str"/> when drawn on device context HDC
		/// using the given font <paramref  name="font"/>
		/// </summary>
		Size MeasureString(string str, Font font);

		void SetBrush(Color color);
		void SetSolidPen(Color color);

		// TODO: use the Font version
		void PrepDrawString(IntPtr hFont, Color color);

		/// <summary>
		/// Draw the given string using the given  font and foreground color at given location
		/// </summary>
		void DrawString(string str, Point point);

		void DrawRectangle(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
		void FillRectangle(int x, int y, int w, int h);

		/// <summary>
		/// Draw a bitmap object at the given position
		/// </summary>
		void DrawBitmap(Bitmap bitmap, Point point, bool blend = false);
		void Line(int x1, int y1, int x2, int y2);
	}
}