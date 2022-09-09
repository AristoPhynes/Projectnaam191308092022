using System;
using System.Collections.Generic;
using System.Text;

namespace GuitareokeConsole.Datasets_FretBoard
{
    class EStandaardCoordinaten
    {


        #region Uitleg van de EstandaardCoordinaten

        #region Voorbeeld 1 - Set met Coordinaten voor "C" in het geval van 24 frets en E-Standaard
        // Voorbeeld 1

        /*
        //Dataset Van Ten alle tijden waarheden over de noot c, op een  24 Frets in E standaard gestemd 6 Snarige Gitaar
        [C](noot)
        (Hoge E-snaar)
        [C](noot)+[C-6](klavierpositie)+[20](Fretpositie)+[1](Hoge E-snaar)
        [C](noot)+[C-5](klavierpositie)+[8](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [C](noot)+[C-5](klavierpositie)+[13](Fretpositie)+[2](B-snaar)
        [C](noot)+[C-4](klavierpositie)+[1](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [C](noot)+[C-5](klavierpositie)+[17](Fretpositie)+[3](G-snaar)
        [C](noot)+[C-4](klavierpositie)+[10](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [C](noot)+[C-5](klavierpositie)+[22](Fretpositie)+[4](D-snaar)
        [C](noot)+[C-4](klavierpositie)+[10](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [C](noot)+[C-4](klavierpositie)+[15](Fretpositie)+[5](A-snaar)
        [C](noot)+[C-3](klavierpositie)+[3](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [C](noot)+[C-4](klavierpositie)+[20](Fretpositie)+[6](Lage E-snaar)
        [C](noot)+[C-3](klavierpositie)+[8](Fretpositie)+[6](Lage E-snaar)

        // Einde Voorbeeld 1
 
        */
        #endregion

        #region aantekeningen Voorbeeld 1
        // Dit zijn een reeks van hypotethische objecten Die samenvallen met de volgende Muzikaal belangrijke Coördinaten.
        // Noot [ 12 instanties ]
        // Klavierpositie[ 4 Instanties ]
        // Snaar[ 6 instanties ]

        // Voorbeeld095129122021 | prereqdata: "Stemming: Estandaard", A=440hz | for this statement to be true at all times.  
        // [C] (noot)+[C-4] (klavierpositie)+[1] (Fretpositie)+[2] (B-snaar)

        // Lijn met data uitgelegd:
        // [(Noot) Filtert/koppelt De Nootbenoeming naar "C"]in dit geval ["C"]
        // +
        // [(Klavierpositie) bepaald in welk octaaf van C0 tot B8 de (noot) zich bevind]
        // +
        // [(B-snaar) Welke Snaar uit Stemming van Gitaar]
        // is eigenlijk {noot+klavierpositie} Benoemd naast { SnaarRegistercoordinaat } namelijk: de tweede snaar gespannen van hoog naar laag-Geörienteerd uit een set van 6 snaren.
        // Het word nagenoeg nooit met het coordinaat van klavierpositie uitgesproken omdat het korter is te refereren naar de "bsnaar", "dsnaar", etc.
        #endregion

        #region Uitleg per coördinaat over Voorbeeld 1
        /* 
            (Noot) Is een coördinaat - Als er een Noot word genoemd in de muziek, Is dit om aan te geven dat geen enkele andere noot gespeeld word dan de noot die benoemd is.
           
            (Noot)
            Filtert de scope van data over deze collectie van noten:
            "C", "Db", "C#", "D", "Eb", "D#", "E", "F", "Gb", "F#", "G", "Ab", "G#", "A", "A#", "Bb", "B"
            Toegegeven: De collectie is met dubbele mollen en kruizen nog niet Geïmplementeerd in deze collectie-
            -Gedeeltelijk omdat de toepassing van dubbele mollen en kruizen buiten de pakket met basisladders valt.
            --Om Het Instrument in optimale condities te willen laten spelen, moeten alle standaardcondities eerst worden vastgesteld -de collectie die er is word als industriestandaard gehanteerd.
            --Daarvoor moeten zoveel mogelijk Muzikale Coördinaten duidelijk zijn voor het programma te leren welke fret wanneer word aangewezen vanuit welk referentiepunt.
            ---Muziekschrift-techisch is het moeilijker om te lezen vs hun lichter of donkerder genoteerde enharmonische equivalenten-
               Geavanceerde stof enkel aanbieden voor geavanceerd geinteresseerden
            In het geval:
            // [C] (noot)+[C-4] (klavierpositie)+[1] (Fretpositie)+[2] (B-snaar)
            Is [C] niet "Db", "C#", "D", "Eb", "D#", "E", "F", "Gb", "F#", "G", "Ab", "G#", "A", "A#", "Bb", "B"

            (klavierpositie) Is een coördinaat - Voor gemak een Factor om te communiceren met bijv Pianisten.
            --Gitaristen noemen in het geval van majeur(akkoordkwaliteit), Ieder C-Akkoord een C-akkoord, ongeacht de klavierpositie.

            (klavierpositie)
            --Tenopzichte van een "Concertstemming", op welk coordinaat bevind zich deze noot in welke toonreeks - een c is niet per definitie c0 of c1
            In het geval:
            // [C] (noot)+[C-4] (klavierpositie)+[1] (Fretpositie)+[2] (B-snaar) 
            Is [C-4] niet "C-0", "C-1", "C-2", "C-3", "C-4", "C-5", "C-6", "C-7", "C-8"

            (Fretpositie) Is een coördinaat - voor het gemak van

            (x-snaar) Is een coördinaat - Samengesteld uit het afnemen van een stemming, Anderzijds gerangschikt met de Hoogste naar als eerste van uitgangspunt.
        */
        #endregion


        #region Deze set met Coördinaten Alleen geldig in Stemming: E-Standaard
        #region E(noot)
        /*  
        [E](noot)
        (Hoge E-snaar)
        [E](noot)+[E-4](klavierpositie)+[0](Fretpositie)+[1](Hoge E-snaar)
        [E](noot)+[E-5](klavierpositie)+[12](Fretpositie)+[1](Hoge E-snaar)
        [E](noot)+[E-6](klavierpositie)+[24](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [E](noot)+[E-4](klavierpositie)+[5](Fretpositie)+[2](B-snaar)
        [E](noot)+[E-5](klavierpositie)+[17](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [E](noot)+[E-5](klavierpositie)+[21](Fretpositie)+[3](G-snaar)
        [E](noot)+[E-4](klavierpositie)+[9](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [E](noot)+[E-4](klavierpositie)+[14](Fretpositie)+[4](D-snaar)
        [E](noot)+[E-3](klavierpositie)+[2](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [E](noot)+[E-4](klavierpositie)+[19](Fretpositie)+[5](A-snaar)
        [E](noot)+[E-3](klavierpositie)+[7](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [E](noot)+[E-2](klavierpositie)+[0](Fretpositie)+[6](Lage E-snaar)
        [E](noot)+[E-3](klavierpositie)+[12](Fretpositie)+[6](Lage E-snaar)
        [E](noot)+[E-4](klavierpositie)+[24](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region F(noot)
        /*
        [F](noot)
        (Hoge E-snaar)
        [F](noot)+[F-4](klavierpositie)+[1](Fretpositie)+[1](Hoge E-snaar)
        [F](noot)+[F-5](klavierpositie)+[13](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [F](noot)+[F-4](klavierpositie)+[6](Fretpositie)+[2](Lage B-snaar)
        [F](noot)+[F-5](klavierpositie)+[18](Fretpositie)+[2](B-snaar))
        ( g snaar )
        [F](noot)+[F-4](klavierpositie)+[10](Fretprositie)+[3](G-snaar)
        [F](noot)+[F-5](klavierpositie)+[22](Fretprositie)+[3](G-snaar)
        ( d snaar )
        [F](noot)+[F-3](klavierpositie)+[3](Fretprositie)+[5](D-snaar)
        [F](noot)+[F-4](klavierpositie)+[15](Fretprositie)+[4](D-snaar)
        ( a snaar )
        [F](noot)+[F-3](klavierpositie)+[8](Fretprositie)+[5](A-snaar)
        [F](noot)+[F-4](klavierpositie)+[20](Fretprositie)+[5](A-snaar))
        (Lage E-snaar)
        [F](noot)+[F-2](klavierpositie)+[1](Fretprositie)+[6](Lage E-snaar)
        [F](noot)+[F-3](klavierpositie)+[13](Fretprositie)+[6](Lage E-snaar)
        */
        #endregion

        #region F#ofGb(noot)
        /*
        [F#](noot) Staat enharmonisch Gelijk aan de [Gb](noot)
        (Hoge E-snaar)
        [F#ofGb](noot)+[F#ofGb-5](klavierpositie)+[14](Fretprositie)+[1](Hoge E-snaar)
        [F#ofGb](noot)+[F#ofGb-4](klavierpositie)+[23](Fretprositie)+[1](Hoge E-snaar)
        ( b snaar )
        [F#ofGb](noot)+[F#ofGb-5](klavierpositie)+[23](Fretprositie)+[2](B-snaar)
        [F#ofGb](noot)+[F#ofGb-4](klavierpositie)+[23](Fretprositie)+[2](B-snaar)
        ( g snaar )
        [F#ofGb](noot)+[F#ofGb-5](klavierpositie)+[23](Fretprositie)+[3](G-snaar))
        [F#ofGb](noot)+[F#ofGb-4](klavierpositie)+[11](Fretprositie)+[3](G-snaar)
        ( d snaar )
        [F#ofGb](noot)+[F#ofGb-5](klavierpositie)+[16](Fretprositie)+[4](D-snaar)
        [F#ofGb](noot)+[F#ofGb-4](klavierpositie)+[4](Fretprositie)+[4](D-snaar)
        ( a snaar )
        [F#ofGb](noot)+[F#ofGb-4](klavierpositie)+[21](Fretprositie)+[5](A-snaar)
        [F#ofGb](noot)+[F#ofGb-3](klavierpositie)+[9](Fretprositie)+[5](A-snaar)
        (Lage E-snaar)
        [F#ofGb](noot)+[F#ofGb-3](klavierpositie)+[14](Fretprositie)+[6](Lage E-snaar)
        [F#ofGb](noot)+[F#ofGb-2](klavierpositie)+[2](Fretprositie)+[6](Lage E-snaar)
        */
        #endregion

        #region G(noot)
        /*
        [G](noot)
        (Hoge E-snaar)
        [G](noot)+[G-5](klavierpositie)+[15](Fretpositie)+[1](Hoge E-snaar)
        [G](noot)+[G-4](klavierpositie)+[3](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [G](noot)+[G-5](klavierpositie)+[20](Fretpositie)+[2](B-snaar)
        [G](noot)+[G-4](klavierpositie)+[8](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [G](noot)+[G-5](klavierpositie)+[24](Fretpositie)+[3](G-snaar)
        [G](noot)+[G-4](klavierpositie)+[12](Fretpositie)+[3](G-snaar)
        [G](noot)+[G-3](klavierpositie)+[0](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [G](noot)+[G-4](klavierpositie)+[17](Fretpositie)+[4](D-snaar)
        [G](noot)+[G-3](klavierpositie)+[5](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [G](noot)+[G-4](klavierpositie)+[22](Fretpositie)+[5](A-snaar)
        [G](noot)+[G-3](klavierpositie)+[10](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [G](noot)+[G-3](klavierpositie)+[15](Fretpositie)+[6](Lage E-snaar)
        [G](noot)+[G-2](klavierpositie)+[3](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region G#ofAb(noot)
        /*
        [G#](noot) Staat enharmonisch Gelijk aan de [Ab](noot)
        (Hoge E-snaar)
        [G#ofAb](noot)+[G#ofAb-5](klavierpositie)+[16](Fretpositie)+[1](Hoge E-snaar)
        [G#ofAb](noot)+[G#ofAb-4](klavierpositie)+[4](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [G#ofAb](noot)+[G#ofAb-5](klavierpositie)+[21](Fretpositie)+[2](B-snaar)
        [G#ofAb](noot)+[G#ofAb-4](klavierpositie)+[9](Fretpositie)+[2](B-snaar))
        ( g snaar )
        [G#ofAb](noot)+[G#ofAb-4](klavierpositie)+[13](Fretpositie)+[3](G-snaar)
        [G#ofAb](noot)+[G#ofAb-3](klavierpositie)+[1](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [G#ofAb](noot)+[G#ofAb-4](klavierpositie)+[6](Fretpositie)+[5](D-snaar)
        [G#ofAb](noot)+[G#ofAb-3](klavierpositie)+[6](Fretpositie)+[5](D-snaar)
        ( a snaar )
        [G#ofAb](noot)+[G#ofAb-4](klavierpositie)+[23](Fretpositie)+[6](A-snaar)
        [G#ofAb](noot)+[G#ofAb-3](klavierpositie)+[11](Fretpositie)+[6](A-snaar)
        (Lage E-snaar)
        [G#ofAb](noot)+[G#ofAb-3](klavierpositie)+[16](Fretpositie)+[6](Lage E-snaar)
        [G#ofAb](noot)+[G#ofAb-2](klavierpositie)+[4](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region A(noot)
        /*
        [A](noot)
        (Hoge E-snaar)
        [A](noot)+[A-5](klavierpositie)+[17](Fretpositie)+[1](Hoge E-snaar)
        [A](noot)+[A-4](klavierpositie)+[5](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [A](noot)+[A-5](klavierpositie)+[22](Fretpositie)+[2](B-snaar)
        [A](noot)+[A-4](klavierpositie)+[10](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [A](noot)+[A-4](klavierpositie)+[14](Fretpositie)+[3](G-snaar)
        [A](noot)+[A-3](klavierpositie)+[2](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [A](noot)+[A-4](klavierpositie)+[7](Fretpositie)+[4](D-snaar)
        [A](noot)+[A-3](klavierpositie)+[7](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [A](noot)+[A-4](klavierpositie)+[12](Fretpositie)+[5](A-snaar)
        [A](noot)+[A-3](klavierpositie)+[12](Fretpositie)+[5](A-snaar)
        [A](noot)+[A-2](klavierpositie)+[0](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [A](noot)+[A-3](klavierpositie)+[17](Fretpositie)+[6](Lage E-snaar)
        [A](noot)+[A-2](klavierpositie)+[5](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region A#ofBb(noot)
        /*
        [A#](noot) Staat enharmonisch Gelijk aan de [Bb](noot)
        (Hoge E-snaar)
        [A#ofBb](noot)+[A#ofBb-5](klavierpositie)+[18](Fretpositie)+[1](Hoge E-snaar)
        [A#ofBb](noot)+[A#ofBb-4](klavierpositie)+[6](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [A#ofBb](noot)+[A#ofBb-5](klavierpositie)+[23](Fretpositie)+[2](B-snaar)
        [A#ofBb](noot)+[A#ofBb-4](klavierpositie)+[11](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [A#ofBb](noot)+[A#ofBb-4](klavierpositie)+[15](Fretpositie)+[3](G-snaar)
        [A#ofBb](noot)+[A#ofBb-3](klavierpositie)+[3](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [A#ofBb](noot)+[A#ofBb-4](klavierpositie)+[20](Fretpositie)+[4](D-snaar)
        [A#ofBb](noot)+[A#ofBb-3](klavierpositie)+[8](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [A#ofBb](noot)+[A#ofBb-3](klavierpositie)+[13](Fretpositie)+[5](A-snaar)
        [A#ofBb](noot)+[A#ofBb-2](klavierpositie)+[1](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [A#ofBb](noot)+[A#ofBb-3](klavierpositie)+[18](Fretpositie)+[6](Lage E-snaar)
        [A#ofBb](noot)+[A#ofBb-2](klavierpositie)+[6](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region B(noot)
        /*
        [B](noot)
        (Hoge E-snaar)
        [B](noot)+[B-5](klavierpositie)+[19](Fretpositie)+[1](Hoge E-snaar)
        [B](noot)+[B-4](klavierpositie)+[7](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [B](noot)+[B-5](klavierpositie)+[24](Fretpositie)+[2](Lage E-snaar)
        [B](noot)+[B-4](klavierpositie)+[12](Fretpositie)+[2](B-snaar)
        [B](noot)+[B-3](klavierpositie)+[0](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [B](noot)+[B-4](klavierpositie)+[16](Fretprositie)+[3](G-snaar)
        [B](noot)+[B-3](klavierpositie)+[4](Fretprositie)+[3](G-snaar)
        ( d snaar )
        [B](noot)+[B-4](klavierpositie)+[21](Fretprositie)+[4](D-snaar)
        [B](noot)+[B-3](klavierpositie)+[9](Fretprositie)+[4](D-snaar)
        ( a snaar )
        [B](noot)+[B-3](klavierpositie)+[14](Fretprositie)+[5](A-snaar)
        [B](noot)+[B-2](klavierpositie)+[2](Fretprositie)+[5](A-snaar)
        (Lage E-snaar)
        [B](noot)+[B-2](klavierpositie)+[19](Fretprositie)+[6](Lage E-snaar)
        [B](noot)+[B-2](klavierpositie)+[7](Fretprositie)+[6](Lage E-snaar)
        */
        #endregion

        #region C(noot)
        /*
        [C](noot)
        (Hoge E-snaar)
        [C](noot)+[C-6](klavierpositie)+[20](Fretpositie)+[1](Hoge E-snaar)
        [C](noot)+[C-5](klavierpositie)+[8](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [C](noot)+[C-5](klavierpositie)+[13](Fretpositie)+[2](B-snaar)
        [C](noot)+[C-4](klavierpositie)+[1](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [C](noot)+[C-5](klavierpositie)+[17](Fretpositie)+[3](G-snaar)
        [C](noot)+[C-4](klavierpositie)+[10](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [C](noot)+[C-5](klavierpositie)+[22](Fretpositie)+[4](D-snaar)
        [C](noot)+[C-4](klavierpositie)+[10](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [C](noot)+[C-4](klavierpositie)+[15](Fretpositie)+[5](A-snaar)
        [C](noot)+[C-3](klavierpositie)+[3](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [C](noot)+[C-4](klavierpositie)+[20](Fretpositie)+[6](Lage E-snaar)
        [C](noot)+[C-3](klavierpositie)+[8](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region C#ofDb(noot)
        /*
        [C#](noot) Staat enharmonisch Gelijk aan de [Db](noot)
        (Hoge E-snaar)
        [C#ofDb](noot)+[C#ofDb-5](klavierpositie)+[21](Fretpositie)+[1](Hoge E-snaar)
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[9](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[14](Fretpositie)+[2](B-snaar)
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[2](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [C#ofDb](noot)+[C#ofDb-5](klavierpositie)+[18](Fretpositie)+[3](G-snaar)
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[6](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [C#ofDb](noot)+[C#ofDb-5](klavierpositie)+[23](Fretpositie)+[4](D-snaar)
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[11](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[16](Fretpositie)+[5](A-snaar)
        [C#ofDb](noot)+[C#ofDb-3](klavierpositie)+[4](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [C#ofDb](noot)+[C#ofDb-4](klavierpositie)+[21](Fretpositie)+[6](Lage E-snaar)
        [C#ofDb](noot)+[C#ofDb-3](klavierpositie)+[9](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region D(noot)
        /*
        [D](noot)
        (Hoge E-snaar)
        [D](noot)+[D-5](klavierpositie)+[22](Fretpositie)+[1](Hoge E-snaar)
        [D](noot)+[D-4](klavierpositie)+[10](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [D](noot)+[D-5](klavierpositie)+[15](Fretpositie)+[2](B-snaar)
        [D](noot)+[D-4](klavierpositie)+[3](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [D](noot)+[D-5](klavierpositie)+[19](Fretpositie)+[3](G-snaar)
        [D](noot)+[D-4](klavierpositie)+[17](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [D](noot)+[D-5](klavierpositie)+[24](Fretpositie)+[4](D-snaar)
        [D](noot)+[D-4](klavierpositie)+[12](Fretpositie)+[4](D-snaar)
        [D](noot)+[D-3](klavierpositie)+[0](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [D](noot)+[D-4](klavierpositie)+[17](Fretpositie)+[5](A-snaar)
        [D](noot)+[D-3](klavierpositie)+[5](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [D](noot)+[D-4](klavierpositie)+[22](Fretpositie)+[6](Lage E-snaar)
        [D](noot)+[D-3](klavierpositie)+[10](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion

        #region D#ofEb(noot)
        /*
        [D#](noot) Staat enharmonisch Gelijk aan de [Eb](noot)
        (Hoge E-snaar)
        [D#ofEb](noot)+[D#ofEb-6](klavierpositie)+[23](Fretpositie)+[1](Hoge E-snaar)
        [D#ofEb](noot)+[D#ofEb-5](klavierpositie)+[11](Fretpositie)+[1](Hoge E-snaar)
        ( b snaar )
        [D#ofEb](noot)+[D#ofEb-5](klavierpositie)+[16](Fretpositie)+[2](B-snaar)
        [D#ofEb](noot)+[D#ofEb-4](klavierpositie)+[4](Fretpositie)+[2](B-snaar)
        ( g snaar )
        [D#ofEb](noot)+[D#ofEb-5](klavierpositie)+[20](Fretpositie)+[3](G-snaar)
        [D#ofEb](noot)+[D#ofEb-4](klavierpositie)+[8](Fretpositie)+[3](G-snaar)
        ( d snaar )
        [D#ofEb](noot)+[D#ofEb-4](klavierpositie)+[1](Fretpositie)+[4](D-snaar)
        [D#ofEb](noot)+[D#ofEb-3](klavierpositie)+[1](Fretpositie)+[4](D-snaar)
        ( a snaar )
        [D#ofEb](noot)+[D#ofEb-4](klavierpositie)+[18](Fretpositie)+[5](A-snaar)
        [D#ofEb](noot)+[D#ofEb-3](klavierpositie)+[6](Fretpositie)+[5](A-snaar)
        (Lage E-snaar)
        [D#ofEb](noot)+[D#ofEb-4](klavierpositie)+[23](Fretpositie)+[6](Lage E-snaar)
        [D#ofEb](noot)+[D#ofEb-3](klavierpositie)+[11](Fretpositie)+[6](Lage E-snaar)
        */
        #endregion
        #endregion

        #endregion

    }
}
