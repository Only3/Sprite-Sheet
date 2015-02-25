
'CREATE

' Flags is the images dir
Dim Images = IO.Directory.GetFiles("Flags")
Dim Bm = New Bitmap(32, 32 * Images.Length)
Using G As Graphics = Graphics.FromImage(Bm)
For i = 0 To Images.Length - 1
G.DrawImage(New Bitmap(Images(i)), 0, 32 * i, 32, 32)
Next
End Using
Bm.Save("Img.png", Imaging.ImageFormat.Png)

'EXTRACT

Dim Img = Image.FromFile("Img.png")
Dim Frame As New Bitmap(32, 32)
Using G As Graphics = Graphics.FromImage(Frame)
' 32 * 1 > Change 1 to the index you want
G.DrawImage(Img, New Rectangle(0, 0, 32, 32), New Rectangle(0, 32 * 1, 32, 32), GraphicsUnit.Pixel)
End Using
' Flags(1) = The Name
' Frame = The Image
