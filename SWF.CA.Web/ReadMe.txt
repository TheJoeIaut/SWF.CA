Das ist das Web Projekt. In der Startup Klasse werden sowohl der DBContext aus dem Data Projekt als auch der InsuranceService für die Dependency Injection registriert.

Der InsuranceCalculationController ist ein MVC Controller die Berechnungsseite lädet, die Anfrage an den Insurance Service (kommt über Dependency Injection) weiterleitet und dann das Ergebnis zurückgibt.

Der InsuranceOptionsController ist ein API Controller der für das anlegen neuer InsuranceOptions verwendet werden kann.
