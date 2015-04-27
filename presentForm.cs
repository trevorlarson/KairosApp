﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KairosApp
{
    public partial class presentForm : Form
    {
        public presentForm(string sermonTitle, string sermonText)
        {
            InitializeComponent();
            sermonTitleLabel.Font = new Font(sermonTitleLabel.Font.FontFamily, 20);
            //sermonTitleLabel.Text = sermonTitle;


            currentSermonTitleLabel.Font = new Font(currentSermonTitleLabel.Font.FontFamily, 20);
            currentSermonTitleLabel.Text = sermonTitle;


            sermonTextTextbox.Text = sermonText;
            bibleVerseTextBox.Text = @" Corinthians 13 New International Version (NIV)

13 If I speak in the tongues[a] of men or of angels, but do not have love, I am only a resounding gong or a clanging cymbal. 2 If I have the gift of prophecy and can fathom all mysteries and all knowledge, and if I have a faith that can move mountains, but do not have love, I am nothing. 3 If I give all I possess to the poor and give over my body to hardship that I may boast,[b] but do not have love, I gain nothing.

4 Love is patient, love is kind. It does not envy, it does not boast, it is not proud. 5 It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. 6 Love does not delight in evil but rejoices with the truth. 7 It always protects, always trusts, always hopes, always perseveres.

8 Love never fails. But where there are prophecies, they will cease; where there are tongues, they will be stilled; where there is knowledge, it will pass away. 9 For we know in part and we prophesy in part, 10 but when completeness comes, what is in part disappears. 11 When I was a child, I talked like a child, I thought like a child, I reasoned like a child. When I became a man, I put the ways of childhood behind me. 12 For now we see only a reflection as in a mirror; then we shall see face to face. Now I know in part; then I shall know fully, even as I am fully known.

13 And now these three remain: faith, hope and love. But the greatest of these is love.";

        }
    }
}
