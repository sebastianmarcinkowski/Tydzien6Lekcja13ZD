# Tydzien6Lekcja13ZD
Realizacja zadania domowego z lekcji 13, z tygodnia 6.

Aplikacja umożliwia załadowanie zdjęcia z dysku, gdy zdjęcie jest załadowane i użytkownik najedzie na zdjęcie na 3 sekundy pojawia się ikonka kosza która umożliwia usunięcie zdjęcia. Podczas wychodzenia z aplikacji zdjęcie jest zapisywane i ładowane ponownie przy starcie aplikacji.

W programie istnieje błąd polegający na tym że w przypadku uruchomienia programu gdy wcześniej już było załadowane zdjęcie i wczytania tego zdjęcia, nie można go zmienić (właściwie nie można nadpisać pliku) -> wyrzucany jest wyjątek że plik jest w użyciu przez inny proces.
