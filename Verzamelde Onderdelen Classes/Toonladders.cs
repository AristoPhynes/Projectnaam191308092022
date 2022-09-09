using System;
using System.Collections.Generic;
using System.Text;

namespace GuitareokeConsole.Datasets_MuziekTheorie
{
    class Toonladders
    {
        #region een BasisCollectie van 12 Array's "DeMajeurladders"
        #region Majeurladders

        #region Geen Mollen Geen Kruisen

        string[] CMajeur = { "C", "D", "E", "F", "G", "A", "B" };

        #endregion

        #region 1 Kruis

        string[] GMajeur = { "G", "A", "B", "C", "D", "E", "F#" };

        #endregion

        #region 2 Kruisen

        string[] DMajeur = { "D", "E", "F#", "G", "A", "B", "C#" };

        #endregion

        #region 3 Kruisen

        string[] AMajeur = { "A", "B", "C#", "D", "E", "F#", "G#" };

        #endregion

        #region 4 Kruisen

        string[] EMajeur = { "E", "F#", "G#", "A", "B", "C#", "D#" };

        #endregion

        #region Overlapping 5 Kruisen of 7 Mollen

        string[] BMajeur = { "B", "C#", "D#", "E", "F#", "G#", "A#" };

        string[] CMolMajeur = { "Cb", "Db", "Eb", "Fb", "Gb", "Ab", "Bb" };

        #endregion

        #region Overlapping 6 Kruisen of 6 Mollen

        string[] FKruisMajeur = { "F#", "G#", "A#", "B", "F#", "G#", "A#" };

        string[] GMolMajeur = { "Gb", "Ab", "Bb", "Cb", "Db", "Eb", "F" };

        #endregion

        #region Overlapping 7 Kruisen of 5 Mollen

        string[] CKruisMajeur = { "C#", "D#", "E#", "F#", "G#", "A#", "B#" };

        string[] DMolMajeur = { "Db", "Eb", "F", "Gb", "Ab", "Bb", "C" };

        #endregion

        #region 4 Mollen

        string[] AMolMajeur = { "Ab", "Bb", "C", "Db", "Eb", "F", "G" };

        #endregion

        #region 3 Mollen

        string[] EMolMajeur = { "Eb", "F", "G", "Ab", "Bb", "C", "D" };

        #endregion

        #region 2 Mollen

        string[] BMolMajeur = { "Bb", "C", "D", "Eb", "F", "G", "A" };

        #endregion

        #region 1 Mol

        string[] FMajeur = { "F", "G", "A", "Bb", "C", "D", "E" };

        #endregion

        #endregion
        #endregion


    }
}
