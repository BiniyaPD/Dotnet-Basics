using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileStreamDemos.FileDemos
{
    class MemoryStreamExample
    {
		public void Main()
		{
			byte[] byteArray;
			char[] charArray;
			UnicodeEncoding unicode = new UnicodeEncoding();
			// Create the data to write to the stream.
			byte[] firstString = unicode.GetBytes("This is first string in the memory.");
			byte[] secondString = unicode.GetBytes("This is new string in the memory.");

			using (MemoryStream memoryStream = new MemoryStream(200))
			{
				// Write the first string to the stream.
				memoryStream.Write(firstString, 0, firstString.Length);

				// Write the second string to the stream, byte by byte.
				int count = 0;
				while (count < secondString.Length)
				{
					memoryStream.WriteByte(secondString[count++]);
				}
				// Write the stream properties to the console.
				Console.WriteLine(
					"Capacity = {0}, Length = {1}, Position = {2}\n",
					memoryStream.Capacity.ToString(),
					memoryStream.Length.ToString(),
					memoryStream.Position.ToString());
				// Set the position to the beginning of the stream.
				memoryStream.Seek(0, SeekOrigin.Begin);
				// Read the first 20 bytes from the stream.
				byteArray = new byte[memoryStream.Length];
				count = memoryStream.Read(byteArray, 0, 20);
				// Read the remaining bytes, byte by byte.
				while (count < memoryStream.Length)
				{
					byteArray[count++] = (byte)memoryStream.ReadByte();
				}
				// Decode the byte array into a char array
				// and write it to the console.
				charArray = new char[unicode.GetCharCount(
					byteArray, 0, count)];
				unicode.GetDecoder().GetChars(
					byteArray, 0, count, charArray, 0);
				Console.WriteLine(charArray);
			}
		}

	}
}
