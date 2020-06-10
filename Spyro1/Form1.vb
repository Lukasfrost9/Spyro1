Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles

Public Class Form1

    Dim monster, deadend, trap, rightpath, total, dc As Integer
    Dim lista() As String
    Dim novalista As String
    Dim i As Integer = 0
    Dim seed As Integer
    Dim clickedonce As Boolean
    Dim NewPictureBox(15) As PictureBox
    Dim bingolist1 = New String() {"All Artisans dragons and all Artisans key chests", "25+ Artisans and Peace Keepers dragons", "100% Stone Hill, Town Square and Cliff Town", "100% Sunny Flight, Artisans Homeworld and Magic Crafters Homeworld"}
    Dim bingolist2 = New String() {"All dragons in Magic Crafters worlds", "100% Alpine Ridge, High Caves and Blowhard", "Collect 9 eggs", “Kill 11 thieves”}
	Dim bingolist3 = New String() {"20+ combined Peace Keepers and Magic Crafters' worlds dragons", "All Dragons in Peace Keepers", "1000 combined gems in Cliff Town, Ice Cavern and Wizard Peak", "Open all chests in Peace Keepers and Magic Crafters worlds"}
	Dim bingolist4 = New String() {"100% 3 boss levels", "Defeat 4 bosses", "Collect 12+ dragons from 4 different worlds", "Collect 55+ dragons"}
	Dim bingolist5 = New String() {"1000 combined gems in Dry Canyon, Metalhead and Jacques", “Defeat Jacques and open the key chest in Tree Tops”, “450 gems in Jacques”, “650 combined gems in Haunted Towers and Jacques”}
	Dim bingolist6 = New String() {"Ignite all rockets", "Evolve/Devolve 7 enemies", "Rescue 8 Dream Weavers worlds’ dragons", "1000 Dream Weavers gems"}
	Dim bingolist7 = New String() {"800 Artisans gems", "600 combined gems in Stone Hill, Dark Hollow and Ice Cavern", "All dragons in Peace Keepers and 500 Artisans gems", "400 combined gems in Artisans Homeworld, Toasty and Dr Shemp"}
	Dim bingolist8 = New String() {"Flame all pots in Cliff Town and 100% Misty Bog", "Die in blue water in 6+ levels", "Open 7 locked chests", “250 gems in each of Ice Cavern, Cliff Town and Misty Bog”}
	Dim bingolist9 = New String() {"3500 gems", "1800 Magic Crafters gems", "1500 Beast Makers gems", “2000 combined Magic Crafters and Beast Makers gems”}
	Dim bingolist10 = New String() {"100% 4 homeworlds", "Rescue 9+ collective dragons in Terrace Village, Dark Hollow and High Caves", "850 combined Homeworld gems", "100% Artisans Homeworld, Peace Keepers Homeworld and Terrace Village”}
	Dim bingolist11 = New String() {"Break all red and purple spring chests", "Get kissed by all flame fairies", "Bash all lamps in Ice Cavern and 100% Terrace Village", "Bash all lamps in Ice Cavern and get all dragons in Haunted Towers"}
	Dim bingolist12 = New String() {"Complete 4 flight levels", "100% Metalhead, Beast Makers Homeworld and Tree Tops", "100% Alpine Ridge, Beast Makers Homeworld and Wild Flight", "700 combined gems in Sunny Flight, Beast Makers Homeworld and Dream Weavers Homeworld"}
	Dim bingolist13 = New String() {"5 Dream Weavers dragons and 500 Dream Weavers gems", "14 Artisans dragons and 7 Beast Makers dragons”, "Extra life chests in 14+ levels", "Hit something with all cannons and lasers"}
	Dim bingolist14 = New String() {"800 combined gems in Town Square, Dr Shemp and High Caves", "250 gems in both Lofty Castle and Magic Crafters Homeworld”, "Destroy 4 strongboxes/locked chests in Dream Weavers worlds", “200 gems in both Stone Hill and Lofty Castle"}
	Dim bingolist15 = New String() {"Break 8 strongboxes", "Enter 12 vortexes", "Transform all fools", "300 gems in each of Ice Cavern, Wizard Peak and Metalhead"}
	Dim bingolist16 = New String() {"Break 12 fireworks chests", "Ignite 4 rockets and break 6 fireworks chests", "Use all supercharge ramps in Dream Weavers worlds", "Use 7 supercharge ramps"}
	Dim bingolist17 = New String() {"One fan chest in 7+ levels", "100% Dry Canyon and Icy Flight", "100% Dark Hollow, Wizard Peak and Dream Weavers Homeworld", "700 Combined gems in Town Square, Crystal Flight and Dark Passage"}
	Dim bingolist18 = New String() {"Defeat Toasty, Jacques and 100% Wild Flight", "All eggs, key chests and locked chests in Peace Keepers", "100% Dark Hollow, Wizard Peak and Jacques", “600 combined gems in Dry Canyon and Haunted Towers”}
	Dim bingolist19 = New String() {"Ride a whirlwind in 6+ levels", "All strongboxes and key chests in Beast Makers worlds", "800 combined gems in Alpine Ridge and Terrace Village", "300 gems in each of Haunted Towers and Dark Passage"}
	Dim bingolist20 = New String() {"Collect 1000 gems from both Peace Keepers and Beast Makers worlds", "Rescue 7 dragons who say ‘thank you for releasing me’", "100% Sunny Flight after talking to Lucas", "Destroy all flight train barrels"}
	Dim bingolist21 = New String() {"Rescue all Dream Weavers dragons that say ‘thank you for releasing me’", "Rescue Nestor and all dragons in Dark Passage", "100% Lofty Castle”, “Light both fires in Dark Hollow and rescue all Beast Makers dragons”}
	Dim bingolist22 = New String() {"100% one flight, boss and homeworld from 3 different worlds", "Game over in Dark Hollow after entering Beast Makers", "8 eggs and 2800 gems", "Flame all flight lanterns”}
	Dim bingolist23 = New String() {"Rescue 2 dragons in Gnasty’s worlds", "All dragons in 10 levels", "All gems in 10 levels", "1000 Combined gems in Terrace Village, Misty Bog and Tree Tops"}
    Dim bingolist24 = New String() {"Enter all Artisans vortexes after entering Magic Crafters”, "All dragons in 5 homeworlds", "Get under 1 minute in 3 flights", "700 gems in both Artisans and Beast Makers worlds"}
    Dim bingolist25 = New String() {"Pick up 10 purple gems", "800 combined gems in High Caves and Terrace Village", "Activate all whirlwinds in Lofty Castle", "Unlock 2 chests with keys, break 2 strong boxes with rockets and break 2 fireworks chests”}

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openseed As New Random()
        Dim newsseed = openseed.Next(0, 10000)
        TextBox2.Text = newsseed
        Dim Rnd As New Random(seed)
        TextBox1.Text = ""
        Dim j = Rnd.Next(0, 4)
        TextBox1.Text += "" + "[ {" + """name""" + ":" + """" + bingolist1(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist2(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist3(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist4(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist5(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist6(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist7(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist8(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist9(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist10(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist11(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist12(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist13(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist14(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist15(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist16(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist17(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist18(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist19(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist20(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist21(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist22(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist23(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist24(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 4)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist25(j) + """" + "}]" + vbNewLine
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        seed = Val(TextBox2.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rnd As New Random(seed)
        TextBox1.Text = ""
        Dim j = Rnd.Next(0, 6)
        TextBox1.Text += "" + "[ {" + """name""" + ":" + """" + bingolist1(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist2(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist3(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist4(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist5(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist6(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist7(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 7)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist8(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist9(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist10(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist11(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist12(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist13(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist14(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist15(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist16(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist17(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist18(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist19(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist20(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 7)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist21(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist22(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist23(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist24(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist25(j) + """" + "}]" + vbNewLine
    End Sub

End Class