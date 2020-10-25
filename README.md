# Pass

Pass on Windowsilla toimiva salasanojenhallintasovellus, jolle on myös oma [Android-versio](https://github.com/arikankainen/pass-android).

Ohjelmalla voidaan luoda `master password`, jonka syöttämällä saadaan avattua lista omista palveluista ja niiden salasanoista. Lista on salattu käyttäen `master password`:ia.

![Master salasana](/docs/master.png)

## Uuden palvelun lisäys

Listalle voi lisätä salasanan lisäksi muitakin tietoja palvelusta johon salasana kuuluu. Salasanoja voidaan generoida automaattisesti, ja salasanan sisältämät merkit sekä pituus voidaan määritellä tarkasti.

![Uusi salasana](/docs/new.png)

## Lista palveluista

Palvelut päätyvät listalle, jossa palveluja voidaan lisätä, muokata ja poistaa. Lista voidaan myös lukita ohjelmaa sammuttamatta, jolloin se tyhjennetään kunnes `master password` syötetään uudelleen.

![Pääikkuna](/docs/main.png)

## Tunnusten kopiointi leikepöydälle

Listan kohdetta tuplaklikkaamalla käyttäjänimi kopioidaan leikepöydälle ja pieni ikkuna ilmestyy hieman läpikuultavana näytön oikeaan alalaitaan. Kun käyttäjänimi on syötetty palveluun leikepöydältä, klikataan `Next`, jolloin salasana kopioituu leikepöydälle. Tämän jälkeen ikkunan voi sulkea, ja leikepöytä tyhjennetään. Ikkunassa on myös nappi palvelun avaamiseen selaimessa.

![Leikepöytä](/docs/clipboard.png)

## Lataus

En ota mitään vastuuta ohjelman mahdollisesti aiheuttamista vahingoista; kukin käyttää ohjelmaa omalla vastuullaan. Toiminta testattu Windows 10 -käyttöjärjestelmällä.

**[Lataa uusin versio](https://github.com/arikankainen/pass-windows/releases)**
