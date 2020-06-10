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
    Dim bingolist1 = New String() {"All Bentley Strong Chests", "20 Strong Chests", "100% Bentley's Outpost", "5 Bentley eggs", "Whack a Mole & Sun Seeds", "2 Bentley sub-area eggs & 2 Sgt.Byrd sub-area eggs"}
    Dim bingolist2 = New String() {"Both tunnel eggs", "Collect 3 eggs in each of Seashell, Dino & Frozen", "Defeat 2 mini bosses", "Collect 9+ eggs in Bamboo & Molten", "550 gems in Frozen & piranha signs Skill Point", "Cat Witches and 1 Sunny Skill Point"}
    Dim bingolist3 = New String() {"5 Agent 9 eggs", "2 eggs in Agent 9", "Agent 9's Lab Skill Point", "You're Doomed I & Molten Thieves II", "Break 10 balloon bottles", "Press all red pressable buttons"}
    Dim bingolist4 = New String() {"Collect 15 Midnight worlds' eggs", "Over 20,000 in Skateboarding", "Collect 30 eggs", "Collect 7 eggs from every world", "400 gems in Bamboo"}
    Dim bingolist5 = New String() {"Mushroom & Country Races", "All gems in 3 speedways", "Repunzel & Bomb Guys I", "All supercharge thieves eggs", "600 combined gems in Molten Crater & Icy Peak", "2 Speedway races"}
    Dim bingolist6 = New String() {"Cat Witches & Cat Hockey", "Activate all powerup types", "Activate all superfly powerups & seahorse Skill Point", "Collect 5 eggs in Fireworks Factory", “All eggs in Sunny Villa”}
    Dim bingolist7 = New String() {"4+ Skateboarding eggs", "Farley & Tanks 1", "Collect 15 Midday worlds' eggs", "Enter Bugbot", "Manta Ray & Bomb Escort II", "Seaweed Skill Point & pay for cat hockey"}
    Dim bingolist8 = New String() {"Pay for Agent 9 & Sheila", "Pay Moneybags for 3 side characters", "Hummingbirds & Boat Shootdown", "Unlock all locked chests", "Unlock 3 locked chests & break 5 headbash chests", "Pay Moneybags in Desert & Crystal", "1000 Midday worlds' gems"}
    Dim bingolist9 = New String() {"Defeat Spike & get 200 gems in Spooky", "Defeat Buzz & hatched Buzz", "7 Skill Points", "Collect 15 Evening worlds' eggs", "7+ eggs collected in Mushroom, Sgt.Byrd's Base & Crawdad"}
    Dim bingolist10 = New String() {"100% Two homeworlds", "100% Sunrise & Evening Homeworlds", "1000 Combined Homeworld gems", "15 Homeworld eggs", "Defeat Bluto & get Dino 'Sergio' Egg"}
    Dim bingolist11 = New String() {"650 Combined gems in Cloud & Spooky", "Bomb Escort I and Sunny Skateboarding II", "Activate powerups in 5 different levels", "2 Hunter Speedway eggs", "Harbor & Country hunter eggs"}
    Dim bingolist12 = New String() {"All Midnight Mountain end of level eggs", "Spirits & 1 yellow thief egg", "1500 Midnight worlds' gems", "700 combined gems in Haunted & Molten", "Break 4 cracked walls & 4 Balloon Bottles"}
    Dim bingolist13 = New String() {"5 Hunter eggs", "100% Harbour", "Twin Dragons & 1 skateboarding Skill Point", "Use a submarine, turret (Bluto) & tank (Haunted)", "Collect 15 Sunrise Worlds' eggs"}
    Dim bingolist14 = New String() {"Kill 6 egg thieves", "450 gems in Fireworks", "You're Doomed I & II", “Both Charmed Skill Points", “All eggs in Enchanted”, "Agent 9 egg in Haunted"}
    Dim bingolist15 = New String() {"Collect 2000 gems", "Enter 12 exit level portals", "Pay 2000 gems to Moneybags", "Pay Moneybags 7 times", "All 3 Sgt Byrd Skill Points", "Sheila Sidescroller I and Bentley's Outpost Skill Point"}
    Dim bingolist16 = New String() {"Defeat Scorch with only green rockets", "Sunny Skateboarding I & Tanks II", "#Bonedance & Haunted Skill Point", "Funky chicken & bonk the giant chicken", "Twin dragons & Nancy"}
    Dim bingolist17 = New String() {"Collect 9+ eggs in Crystal Islands & Frozen Altars", "100% Cloud Spires", "1000 Sunrise worlds' gems", "Sleepyhead & Lost Fleet subs II", "Shoot down all birds in Icy & Lost"}
    Dim bingolist18 = New String() {"Farley egg & pay Moneybags in Spooky & Cloud", "All eggs in Desert Ruins", "Pay for Bentley & Sgt Byrd", “All eggs & 300 gems in Icy”, "Bone Dance & enter the unused area in Dino"}
    Dim bingolist19 = New String() {"Ignite all rockets & destroy all mystery bottles", "Ignite all rockets & destroy all fireworks bottles", "Sheila Sidescroller I & Bamboo Autoscroller", "Collect 7 Sheila eggs", "Pay all Moneybags in Midday worlds"}
    Dim bingolist20 = New String() {"Ride a whirlwind in 9+ levels", "Pay for Bentley with 20+ eggs collected", "100% Honey", "5 Speedway eggs", “All invincibility powerups & 1 Molten Skill Point”}
    Dim bingolist21 = New String() {"Moneybags egg", "250 Sparx level gems", "Talk to Zoe in 5+ levels", "Defeat Starfish boss", "Beans II & Tiki Heads", "100% Crawdad", "400 combined gems in Sunny & Agent 9's Labs"}
    Dim bingolist22 = New String() {"Pay for Nancy & Mushroom Hunter challenge", "Destroy all fireworks & mystery Bottles", "Collect 4 eggs & 500 gems in Charmed Ridge", "All eggs in Lost", "Enchanted Skateboarding II & Boxing I", "Boxing Skill Point & destroy 5 fireworks bottles"}
    Dim bingolist23 = New String() {"Collect 8+ eggs in Enchanted & Lost", "Destroy 15 Headbash Chests", "100% Sheila’s Alp", "Collect 7 side character home level eggs", "Unlock Sheila & collect 4+ Sgt.Byrd eggs", "Unlock Sheila & break all boulders In her level"}
    Dim bingolist24 = New String() {"Talk to all Frozen penguins after collecting 12+ Midday worlds' eggs", "Sandcastle & Ninja HQ eggs", "Both Dino Skill Points", "Destroy 8 cracked surfaces", “Collect 3+ eggs in 8 levels”, "Bamboo Bentley egg and Crystal slide"}
    Dim bingolist25 = New String() {"Both slide eggs", "150 gems in Spider", "Swim underwater in 8+ levels", "15 butterfly jars", "Pick up 6 different mouth items", "Seashell tunnel and Lost Skateboarding I"}

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openseed As New Random()
        Dim newsseed = openseed.Next(0, 10000)
        TextBox2.Text = newsseed
        Dim Rnd As New Random(seed)
        TextBox1.Text = ""
        Dim j = Rnd.Next(0, 6)
        TextBox1.Text += "" + "[ {" + """name""" + ":" + """" + bingolist1(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist2(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 6)
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