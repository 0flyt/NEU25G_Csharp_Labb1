# Labb1 � Hitta tal i str�ng med tecken

## Uppgift
Skapa en konsollapplikation som ber anv�ndaren mata in en text (string) i konsollen.  
Den inmatade str�ngen ska sedan s�kas igenom efter alla delstr�ngar som �r tal som b�rjar och slutar p� samma siffra, **utan att start/slutsiffran, eller n�got annat tecken �n siffror f�rekommer d�remellan**.

Exempel:  
- `3463` �r ett korrekt s�dant tal.  
- `34363` �r **inte** korrekt, eftersom det finns ytterligare en `3:a` i talet, f�rutom start och slutsiffran.  
- Str�ngar med bokst�ver i t.ex. `95a9` �r inte heller ett korrekt tal.  

---

## Output
F�r varje s�dan delstr�ng som matchar kriteriet ovan ska programmet skriva ut en rad med hela str�ngen, men d�r delstr�ngen �r markerad i en **annan f�rg** (i detta exempel: orange).  

Exempel output f�r input: "29535123p48723487597645723645"

**2953512**3p48723487597645723645
29**535**123p48723487597645723645
295**35123**p48723487597645723645
29535123p**487234**87597645723645
29535123p4**872348**7597645723645
29535123p48**723487**597645723645
29535123p487**2348759764572**3645
29535123p4872**3487597645723**645
29535123p48723**48759764**5723645
29535123p4872348**75976457**23645
29535123p48723487**597645**723645
29535123p4872348759**76457**23645
29535123p48723487597**6457236**45
29535123p487234875976**4572364**5
29535123p4872348759764**5723645**

Ni kan v�lja vilka f�rger ni skriver ut med s� l�nge man ser skillnad p� dem. Ni
byter f�rg genom att �ndra v�rde p� Console.ForegroundColor.

---

## Addera ihop alla tal och skriv ut totalen
Programmet ska ocks� addera ihop alla tal den hittat enligt ovan och skriva ut summan sist i programmet.  
G�r g�rna en tom rad emellan f�r att skilja fr�n output ovan.  

Exempel output f�r input �29535123p48723487597645723645�:
Total = 5836428677242

---

## Redovisning
- Uppgiften ska l�sas individuellt.  
- Checka in din l�sning som ett nytt repo p� GitHub.  
- L�mna in uppgiften p� Itslearning med en kommentar inneh�llande din GitHub-l�nk.  

---

## Betygskriterier
F�r **Godk�nt** ska f�ljande vara uppfyllt:  

- Programmet ska fungera enligt beskrivningen ovan.  
- Om man matar in exemplet ska man f� samma output som ovan.  
- Det ska �ven fungera generellt, oavsett vilken str�ng man matar in.  
- B�da uppgifterna ska vara l�sta:  
  1. Programmet skriver ut alla delstr�ngar som i exemplet.  
  2. D�refter r�knas summan ut och skrivs ut.  
- Koden ska vara v�lstrukturerad, ha v�l valda namn p� funktioner och variabler, och vara l�tt att f�rst�.  
