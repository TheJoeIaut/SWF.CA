Das Services Projekt kapselt die UseCases der Applikation. Zusammengehörige Usecases sind in einem Service zusammengefasst.

Um Wartbarkeit und Testbarkeit zu erhöhen, implementieren alle Services ein entsprechendes Interface.

Der Insurance Service bekommt über Dependency Injection einen DbContext übergeben. Danach wird abgefragt ob es Insurances gibt, die für die übergebene Wohnungsgröße passen und das erste gefundene Element zurückgegeben.