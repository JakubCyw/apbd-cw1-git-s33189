W tym przypadku nie uzyto fast-forward,
ponieważ w obu branchach był zrobiony nowy commit
przez to nie dało się jasno nałożyć jednego na drugie i trzeba
było dodać rzeczy z obu branchów.

1. Git wykona fast-forward w momencie kiedy branch któego chcemy scalić
nie ma nowych comitów od momentu rozwidlenia.

Natomiast merge commit w momencie kiedy obie gałęzie mają niezależne commity.

2. Marge zachowuje rozgałezienia i łączy je natomiast rebase przenosi
commity jednej gałęzi na koniec drugiej. Marge tworzy dodatkowy commi a
rebase nie tworzy zmienia tylko hashe commitów przenoszonych.

3. Przy tworzeniu rebase miałem konflikt w README wiec usunełem mniej
pasującą wersje zrobiłem git add i kontynułowałem rebase