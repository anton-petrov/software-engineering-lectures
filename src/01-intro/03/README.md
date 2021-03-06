# Основные области знаний SWEBOK

В третьей лекции по программной инженерии речь идет о пяти основных областях знаний
из стандарта SWEBOK. Эти области соответствуют пяти  процессам разработки
программного обеспечения:

* инженерия (выработка) требований;
* проектирование;
* конструирование (т.е. написание кода);
* тестирование;
* сопровождение.

<!--more-->

SWEBOK формализует ключевые понятия для каждого из этапов разработки ПО. Например,
в области знаний «Тестирование» определяется, что такое *сбой* (fault) программы
и как он связан с *ошибкой* (error), допущенной программистом.

Кроме того, области знаний содержат определенные инструкции по управлению процессами
разработки. Так, управление конструированием включает три этапа:

1. создание модели процесса в зависимости от выбранной модели разработки;
2. планирование, определение расписания работ;
3. измерение показателей для корректирования разработки по мере ее выполнения.

В то же время, SWEBOK не детализует взаимодействие между различными процессами разработки.
Связь между процессами сильно зависит от выбранной модели разработки. Например,
в [каскадной модели][cascade] процессы выполняются последовательно в порядке
их перечисления выше: сначала определяются требования, потом проектируется
архитектура модели, и так далее. Согласно же [гибкой методологии][agile]
(agile development) требования к продукту уточняются по мере разработки,
а тестирование неразрывно связано с проектированием и разработкой
([разработка через тестирование][tdd], test-driven development).

[cascade]: https://ru.wikipedia.org/wiki/%D0%9A%D0%B0%D1%81%D0%BA%D0%B0%D0%B4%D0%BD%D0%B0%D1%8F_%D0%BC%D0%BE%D0%B4%D0%B5%D0%BB%D1%8C
[agile]: https://ru.wikipedia.org/wiki/%D0%93%D0%B8%D0%B1%D0%BA%D0%B0%D1%8F_%D0%BC%D0%B5%D1%82%D0%BE%D0%B4%D0%BE%D0%BB%D0%BE%D0%B3%D0%B8%D1%8F_%D1%80%D0%B0%D0%B7%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%BA%D0%B8
[tdd]: https://ru.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B7%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%BA%D0%B0_%D1%87%D0%B5%D1%80%D0%B5%D0%B7_%D1%82%D0%B5%D1%81%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5
