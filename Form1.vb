Public Class Form1

    Dim monster, deadend, trap, rightpath, total, dc As Integer
    Dim lista() As String
    Dim novalista As String
    Dim i As Integer = 0
    Dim seed As Integer
    Dim clickedonce As Boolean
    Dim NewPictureBox(15) As PictureBox
    Dim bingolist1 = New String() {"All Bentley Strong Chests", "20 Strong Chests", "100% Bentley's Outpost", "5 Bentley Eggs", "Whack a Mole & Sun Seeds"}
    Dim bingolist2 = New String() {"Both tunnel eggs", "Collect 3 Eggs in Seashell Shore, Dino Mines and Frozen Altars", "Defeat 2 mini bosses", "9+ eggs in Bamboo Terrace and Molten Crater", "All gems in Frozen Altars and Piranha Signs Skill Point"}
    Dim bingolist3 = New String() {"5 Agent 9 eggs", "2 Eggs in Agent 9", "Agent 9's Lab Skill Point", "You're Doomed 1 and Molten Thieves 2", "Break 10 balloon bottles"}
    Dim bingolist4 = New String() {"Collect 15 Midnight Mountain Eggs", "Collect 15 Midday Gardens Eggs", "Collect 30 Eggs", "Collect 7 eggs from every world", "Collect 15 free standing eggs"}
    Dim bingolist5 = New String() {"Mushroom and Country Races", "All gems in 3 speedways", "Sheila Juliet and Bomb Guys I", "All supercharge thieves eggs", "600 combined gems in Molten Crater and Icy Peak", "2 Speedway races"}
    Dim bingolist6 = New String() {"Cat Wizards & Cat Hockey", "Activate all powerup types", "Activate all superfly powerups and seahorse Skill Point", "Collect 5 eggs in Fireworks Factory", “All eggs in Sunny Villa”}
    Dim bingolist7 = New String() {"4+ Skateboarding Eggs", "Farley and Tanks 1", "Over 20,000 in Skateboarding", "15 Butterfly Jars", "Manta Ray And Pay for Sgt.Byrd", "Seaweed Skill Point and pay for cat hockey"}
    Dim bingolist8 = New String() {"Pay for Agent 9 and Sheila", "Pay for Crystal Island Bridge", "Pay 2000 gems to moneybags", "Unlock all locked chests", "Unlock 3 locked chests And break 5 headbash chests", "Pay moneybags in Desert Ruins And Crystal Islands", "1000 Midday Gardens gems"}
    Dim bingolist9 = New String() {"Defeat Spike And Scorch", "Defeat Buzz And Hatched Buzz", "7 Skill Points", "Collect 15 Evening Lake Eggs", "7+ eggs collected in Country Speedway, Sgt.Byrd's Base and Crawdad Farm"}
    Dim bingolist10 = New String() {"100% Two homeworlds", "100% Sunrise Spring And Evening Lake Homeworlds", "1000 Combined Homeworld gems", "15 Homeworld Eggs", "Defeat Bluto and get Dino Mines Sergio Egg"}
    Dim bingolist11 = New String() {"650 Combined gems in Cloud Spires And Spooky Swamp", "Bomb Escort eggs", "Activate powerups in 5 different levels", "2 Hunter Speedway challenges", "Harbor Speedway and Country Speedway hunter eggs"}
    Dim bingolist12 = New String() {"All Midnight Mountain end of level eggs", "Spirits And 1 yellow thief egg", "1500+ Midnight Mountain gems", "1000 combined gems in Dino Mines and Desert Ruins", "Break 4 cracked walls and 4 Balloon Bottles"}
    Dim bingolist13 = New String() {"Five Hunter eggs", "100% Harbour Speedway", "Twin Dragons And 1 skateboarding Skill Point", "Use a submarine, turret (Bluto) And tank (Haunted)", "Collect 15 Sunrise Spring Eggs"}
    Dim bingolist14 = New String() {"Kill 6 egg thieves", "450 gems in Fireworks Factory", "You're Doomed 1 and 2", “Both Charmed Ridge Skill Points", “All eggs in Enchanted Towers”}
    Dim bingolist15 = New String() {"Collect 2000 gems", "Enter 12 exit level portals", "Pay Moneybags 7 times", "All 3 Sgt Byrd Skill Points", "Free all hummingbirds and shoot all boats eggs"}
    Dim bingolist16 = New String() {"Defeat Scorch with only green rockets", "Haunted Tomb Skill Point and Tanks II", "#Bonedance and 1 Sunny Villa Skill Point", "Funky chicken and bonk the giant chicken", "Twin dragons and Nancy"}
    Dim bingolist17 = New String() {"Collect 9+ Eggs in Crystal Islands and Frozen Altars", "100% Cloud Spires", "1000+ Sunrise Spring gems", "Sleepyhead and Lost Fleet subs II", "Shoot down all birds in Icy Peak and Lost Fleet"}
    Dim bingolist18 = New String() {"Farley egg and pay Moneybags in Spooky Swamp and Cloud Spires", "All eggs in Desert Ruins", "Pay for Bentley and Sgt Byrd", “All eggs and 300 gems in Icy Peak”, "Bone Dance and enter the unused area in Dino Mines"}
    Dim bingolist19 = New String() {"Ignite all rockets and destroy all mystery bottles", "Ignite all rockets and destroy all fireworks bottles", "Sheila sidescroller I and Bamboo autoscroller", "Collect 7 Sheila eggs", "Pay Moneybags in Charmed Ridge and Spooky Swamp"}
    Dim bingolist20 = New String() {"Ride a whirlwind in 9+ levels", "Pay for Bentley with +20 eggs collected", "100% Honey Speedway", "5 Speedway Eggs", “All invincibility powerups and 1 Molten Crater Skill Point”}
    Dim bingolist21 = New String() {"Moneybags egg", "250 Sparx Level gems", "Talk to all Zoe in 5+ levels", "Defeat Starfish Reef boss", "Enter Bugbot Factory", "100% Crawdad Farm", "400 combined gems in Sunny Villa and Agent 9's Labs"}
    Dim bingolist22 = New String() {"Pay for Nancy and Mushroom Speedway Hunter challenge", "All Fireworks Bottles and Mystery Bottles", "Collect 4 eggs and 500 gems in Charmed Ridge", "All eggs in Lost Fleet", "Nancy and Yeti Boxing I", "Yeti Boxing Skill Point and destroy 5 fireworks bottles"}
    Dim bingolist23 = New String() {"Collect 8+ eggs in Enchanted Towers and Lost Fleet", "Destroy 15 Headbash Chests", "100% Sheila’s Alp", "Collect 7 side character home level eggs", "Unlock Sheila and collect 4+ Sgt.Byrd eggs", "Unlock Sheila And break all boulders In her level"}
    Dim bingolist24 = New String() {"Talk to all Frozen Altars penguins after collecting 18+ eggs", "Sandcastle and Ninja HQ eggs", "Both Dino Mines Skill Points", "Destroy 8 cracked surfaces", “Collect 3+ eggs in 8 levels”}
    Dim bingolist25 = New String() {"Both slide eggs", "150 gems in Spider Town", "Swim underwater in 8 levels", "Both beans eggs", "Pick up 6 different mouth items"}

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openseed As New Random()
        Dim newsseed = openseed.Next(0, 1000)
        TextBox2.Text = newsseed
        Dim Rnd As New Random(seed)
        TextBox1.Text = ""
        Dim j = Rnd.Next(0, 5)
        TextBox1.Text += "" + "[ {" + """name""" + ":" + """" + bingolist1(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
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
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist14(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
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
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist24(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist25(j) + """" + "}]" + vbNewLine
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        seed = Val(TextBox2.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rnd As New Random(seed)
        TextBox1.Text = ""
        Dim j = Rnd.Next(0, 5)
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
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist14(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
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
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist24(j) + """" + "}," + vbNewLine
        j = Rnd.Next(0, 5)
        TextBox1.Text += "" + " {" + """name""" + ":" + """" + bingolist25(j) + """" + "}]" + vbNewLine
    End Sub

End Class