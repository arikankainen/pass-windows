# Pass

Pass on Windowsilla toimiva salasanojenhallintasovellus, jolle on myös oma [Android-versio](https://github.com/arikankainen/pass-android). Ohjelmalla voidaan hallinnoida kaikkien käytössä olevien palveluiden käyttäjätunnuksia ja salasanoja, sekä muita palvelun käyttöön liittyviä tietoja.

![Pass](/docs/main.png)

## Käyttö

Ohjelma näyttää kaikki siihen lisätyt palvelut listana, jossa näkyvissä on palvelun nimi, verkko-osoite, käyttäjänimi, salasana sekä kommentit liittyen palveluun. Salasana korvataan oletuksena `x`-kirjaimilla, mutta asetusvalikosta voi valita sen näyttämisen myös selväkielisenä. Ohjelman tilapalkissa näytetään palvelujen yhteismäärä, sekä päivämäärä listan viimeisimmästä varmuuskopiosta.

## Valikot

**_File / Save list_**\
Listan tallennus. Ohjelma tosin myös varmistaa halutaanko lista tallentaa, jos ohjelma yritetään sulkea tallentamatta muutoksia.

**_File / Backup list_**\
Lista palveluista on tallennettu ohjelman kanssa samaan kansioon salattuna, nimellä `pass.dat`. Kyseisestä tiedostosta voidaan ottaa helposti varmuuskopioita, jos listan tallennuksessa sattuisi menemään jotain pieleen. Varmuuskopiot listasta tallennetaan samaan paikkaan, tiedostonimellä `pass_backup_2020-10-24_09-48-14.dat` (jossa siis on varmuuskopiohetken päivämäärä). Varmuuskopion palauttaminen onnistuu kun varmuuskopion nimeää oletusnimellä `pass.dat`.

**_List / Change master password_**\
Ohjelmaa ensimmäistä kertaa käynnistettäessä luodaan pääsalasana, ja tästä sen voi vaihtaa. Kaikki palveluiden tiedot salataan käyttäen pääsalasanaa, joten pääsalasanan tulee olla kohtuullisen vahva. Mikäli pääsalasana unohdetaan, ei listaa saa enää mitenkään auki.

**_List / Lock_**\
Lista voidaan lukita, eli kaikki sisältö piilotetaan ja ohjelman käyttö onnistuu vain ottamalla lukon pois ja syöttämällä pääsalasanan.

**_List / Add, Modify, Delete_**\
Voidaan lisätä, muokata tai poistaa palvelu listalta.

**_List / Copy to clipboard_**\
Palvelun käyttäjänimi ja salasana kopioidaan vuorotellen leikepöydälle, josta ne voi helposti liittää palvelun kirjautumisikkunaan.

**_Settings / Show passwords_**\
Valitaan näytetäänkö salasana listalla selväkielisenä vai korvattuna x-kirjaimilla.

**_Settings / Prompt to unlock list on startup_**\
Valitaan, halutaanko että ohjelma tarjoaa ohjelmaa käynnistettäessä listan lukituksen avausta, eli kysyy pääsalasanaa.

**_Settings / Minimize on lock_**\
Pienennetäänkö ohjelma, kun lista lukitaan.

**_Settings / Minimize on copy_**\
Pienennetäänkö ohjelma, kun kirjautumistiedot kopioidaan leikepöydälle.

## Palvelun lisäys tai muokkaus

![Pass](/docs/add.png)

Palvelun tiedot voidaan lisätä valitsemalla pääikkunasta `List / Add`, tai jo lisätyn palvelun tietoja voidaan muokata valitsemalla `Modify`. Palvelun voi poistaa `Delete`:llä. Komentoihin löytyy myös vastaavat kuvakkeet työkaluriviltä.

Avautuvaan ikkunaan täytetään tiedot palvelusta; palvelun nimi, mahdollinen verkko-osoite, palvelun käyttäjänimi sekä salasana.Kommentteihin voi lisätä mitä tahansa tekstiä, esimerkiksi sähköpostipalvelun palvelinosoitteita, asiakasnumeroita tms. `Show password`-valinnalla valitaan, näytetäänkö salasana ikkunassa selväkielisenä.

## Salasanan generointi

`Generate password`-napilla saadaan auki salanojen generointi-ikkuna. Mikäli palveluun oli jo määritelty salasana, näytetään se `Old password`-kentässä, ja uusi generoitu salasana ilmestyy `New password`-kenttään. Molemmille salasanoille on oma nappi jolla ne voi kopioida leikepöydälle. `Generate`-nappi generoi uuden salasanan.

Alapuolella voidaan määritellä salasanan pituus. Oletuksena pituus on 32 merkkiä, mutta aivan kaikki palvelut ei hyväksy näin pitkää salasanaa, joten joskus pituutta täytyy muuttaa. Lisäksi pituuden alla määritellään, mistä merkeistä salasanan halutaan koostuvan. Valittavana on viisi eri kategoriaa, joista otetaan salasanaan merkkejä satunnaisesti. Jokaisen kategorian voi erikseen ottaa mukaan/jättää pois muuttamalla niiden valitarukseja. Myös kategorian sisältämiä merkkejä voidaan muokata. Esimerkiksi on tullut eteen palveluita, jotka eivät hyväksy salasanaan kaikkia `Special characters #2`-kategorian merkkejä, jolloin sen voi ruksata pois tälläisen palvelun kohdalla.

Oletuksena kun kaikki merkit on käytössä ja salasanan pituus on 32 merkkiä, tulee salasanasta erittäin turvallinen (ja hankala muistaa). Ikkunasta löytyy lisäksi nappi, jolla leikepöydän voi tyhjentää, jos sinne on generointivaiheessa kopioinut salasanoja.

## Kirjautumistietojen käyttö

![Pass](/docs/clipboard.png)

Tuplaklikkaamalla pääikkunan listalta palvelua (tai valitsemalla `List / Copy to clipboard`, tai työkalurivin leikepöytäkuvakkeen) avautuu näytön oikeaan alakulmaan pieni ikkuna, joka kertoo että käyttäjänimi on nyt kopioitu leikepöydälle. Ikkuna on hieman läpikuultava, ja se pysyy näkyvissä vaikka ei olisikaan aktiivisena. Salasana voidaan nyt liittää palvelun kirjautumisikkunaan. Mikäli palvelulle on annettu verkko-osoite, voidaan se avata oletusselaimeen `Open in browser`-napilla.

Klikkamalla `Next`, kopioidaan palvelun salasana leikepöydälle. Lopuksi klikkamalla `Close` tai sulkemalla ikkunan ruksista, leikepöytä tyhjennetään.

## Lataus

En ota mitään vastuuta ohjelman mahdollisesti aiheuttamista vahingoista; kukin käyttää ohjelmaa omalla vastuullaan. Toiminta testattu Windows 10 -käyttöjärjestelmällä.

**[Lataa uusin versio](https://github.com/arikankainen/pass-windows/releases)**
