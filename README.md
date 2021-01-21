# GK-Project3-Colors_reduction
<b>Colors reduction</b> to program przedstawiający sposób działania wybranych algorytmów redukcji kolorów stworzony w ramach przedmiotu "Grafika komputerowa 1" na 5. semestrze studiów.

Użytkownik obsługuje program za pomocą myszki. W przypadku określania parametrów redukcji możliwe jest wpisanie odpowiednich danych z klawiatury.

W zakładce Menu na górnym pasku narzędzi dostępne są opcje:
- Greyscale - opcja określa czy dany obraz ma być wyświetlony w odcieniach szarości (domyślnie nie),
- Load image - kliknięcie spowoduje pojawienie się okna dialogowego, za pomocą którego można wybrać z dysku obraz, na którym użytkownik będzie pracować,
- Exit - wybranie opcji zamyka aplikację. 

Panel po lewej stronie okna aplikacji zawiera grupy opcji edycji obrazu wyświetlonego na środku okna. Edytowany obraz znajdzie się po prawej stronie.

<b>Select algorithm</b> to pole wyboru algorytmu redukcji kolorów. Dostępne opcje to:
- <b>average dithering</b> - rozpraszanie średnie,
- <b>error diffusion dithering</b> - metoda propagacji błędu,
- <b>ordered dithering random</b> - metoda uporządkowanego drżenia, w której pozycja we wzorze <b>n×n</b> wybierana jest losowo,
- <b>ordered dithering random</b> - metoda uporządkowanego drżenia, w której pozycja we wzorze <b>n×n</b> uzależniona jest od pozycji piksela,
- <b>popularity algorithm</b> - algorytm popularnościowy.

Kliknięcie przycisku <b>Refresh</b> spowoduje odświeżenie edytowanego obrazu na podstawie zmienionych parametrów edycji. Jeżeli zmieniamy jedynie zastosowany algorytm, odświeżenie następuje automatycznie na podstawie aktualnie wybranych parametrów.

<b>Params for dithering</b> to grupa parametrów dla algorytmów typu <i>dithering</i>:
- <b>Kr</b> - wynikowa liczba kolorów kanału R, domyślnie Kr=8,
- <b>Kg</b> - wynikowa liczba kolorów kanału G, domyślnie Kg=128,
- <b>Kb</b> - wynikowa liczba kolorów kanału B, domyślnie Kb=32.

Każdy powyższy parametr jest liczbą całkowitą z przedziału <2, 256>.

<b>Params for popularity algorithm</b> grupa parametrów dla algorytmu popularnościowego. Grupa zawiera jeden parametr <b>K</b> określający ile najczęściej występujących kolorów algorytm ma uwzględnić. Jest to liczba całkowita z przedziału <4, 262144>, domyślnie K=1024.

Na starcie w aplikacji załadowane jest słynne zdjęcie szwedzkiej modelki Leny Forsén (wcześniej Söderberg) z 1972 roku.

<br /><b>Autor:</b><br /> Adam Ryl, student PW MiNI G3.