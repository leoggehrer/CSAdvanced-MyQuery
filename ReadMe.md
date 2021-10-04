Übung:
------

 
**Lernziele der Aufgaben Teil A:** 
- Verstehen und verwenden von Lambda-Expressions
- Verstehen und verwenden von Erweiterungsmethoden
 
## MyQuery
## Teil A
### Grundsystem
 
**MyQuery** Erstellen Sie die Projektstruktur von MyQuery und fassen Sie die einzelnen Projekte zu einer Solution zusammen. Die Struktur besteht aus den Projekten:
 
|Name|Beschreibung|
|---|---|
|MyQuery.Logic|In diesem Projekt ist die gesamte Logik implementiert.|
|MyQuery.Logic.UnitTest|In diesem Projekt befinden sich die UnitTests der Logik.|
|MyQuery.ConApp|Ein Konsolen-Anwendung zum Testen der Logik.|
 
Verbinden Sie die Abhängigkeiten der einzelnen Projekte untereinander.
 
**Funktionsumfang** Erweitern Sie den Funktionsumfang für alle Sammlungen (IEnumerable&lt;T&gt;) um folgende Operationen:
 
|Name|Beschreibung|
|---|---|
|*IEnumerable&lt;T&gt; Filter(Func<T, bool> predicate)*|Filtert die Auflistung nach dem angebenen Kriterium.|
|*IEnumerable&lt;TResult&gt; Map(Func<T, TResult> selector)*|Mapped den Quelltyp T auf einen Zieltyp TResult.|
|*T[] ToArray()*|Konvertiert die Auflistung zu einem Array.|
|*List&lt;T&gt; ToList()*|Konvertiert die Auflistung zu einer Liste.|
|*double Sum(Func<T, double> transform)*|Summiert die Werte von der Funktion 'transform'.|
|*double? Min(Func<T, double> transform)*|Liefert den Minimalwert der Auflistung.|
|*double? Max(Func<T, double> transform)*|Liefert den Maximalwert der Auflistung.|
|*double? Average(Func<T, double> transform)*|Liefert den Durchschnittswert der Auflistung.|
|*IEnumerable&lt;T&gt; ForEach(Action&lt;T&gt; action)*|Führt für jedes Element der Auflistung die 'action' aus.|
|*IEnumerable&lt;T&gt; ForEach(Action&lt;int, T&gt; action)*|Führt für jedes Element der Auflistung die 'action' aus und liefert zusätzlich den Parameter n-tes Element.|
|*IEnumerable&lt;T&gt; Distinct()*|Bereinigt die Auflistung von Duplikaten.|
 
**Funktionsumfang für Experten (optional)** Erweitern Sie den Funktionsumfang für alle Sammlungen (IEnumerable&lt;T&gt;) um folgende Operationen:
 
|Name|Beschreibung|
|---|---|
|*IEnumerable&lt;T&gt; SortBy(Func<T, TKey> orderBy)*|Sortiert die Auflistung nach orderBy.|
|*IEnumerable&lt;T&gt; ForEach(ActionRef&lt;int, ref bool, T&gt; action)*|Führt für jedes Element der Auflistung die 'action' aus, liefert zusätzlich den Parameter n-tes Element und zusätzlich kann die Iteration über den ref-Parameter beendet werden.|
 
**Anmerkung**: Der erweiterte Funktionsumfang ist nur für Experten, also optional.
 
### Testen des Systems
 
Erstellen Sie mindestens zwei **UnitTests** pro **Funktion** und
Testen Sie das System ausführlich. Bitte achten Sie auf eine sinnvolle
Gestaltung der Tests!
 
**Namenskonvention für UnitTests**:
 
ActionSubject\_Condition\_ExpectedResult
 
## Hilfsmitteln
-   keine Angaben
 
## Abgabe
-   Termin: 1 Woche nach der Ausgabe
 
-   Klasse:
 
-   Name:
 
## Quellen
-  keine Angabe
 
# 
<center> **Viel Erfolg!** </center>