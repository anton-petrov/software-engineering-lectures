---
title: Хранение данных в приложениях
category: Разработка современных программных систем
---

В самых разнообразных приложениях часто возникает задача хранения данных вне оперативной памяти (data persistence), 
чтобы информация оставалась доступной после завершения работы программы, ее породившей. Также требуется, 
чтобы из сохраненных данных можно было восстановить объект, эквивалентный сохраненному.

 Можно выделить по крайней мере два способа решения этой задачи:

  * Сериализация данных в виде потока байтов. В зависимости от выбранного формата, сериализованные данные могут храниться 
    в двоичном или текстовом виде. В первом случае, как правило, оптимизируется объем данных, во втором — 
    уделяется внимание тому, чтобы информация могла восприниматься программистом.
  * Сохранение данных в реляционную базу данных при помощи объектно-реляционного отображения (object-relational mapping, ORM).

У каждого способа хранения данных есть свои преимущества и недостатки. ORM подразумевает определенные затраты 
на сопровождение базы данных; с другой стороны, структуризация данных в БД позволяет более эффективно их анализировать. 
Сериализация данных может использоваться не только для хранения данных, но и для их передачи, например, по сети; 
два формата сериализации (XML и JSON) де-факто являются стандартами передачи данных в веб-приложениях.

Встроенные средства сериализации (как правило, в двоичные потоки данных) присутствуют во многих языках программирования. 
Например, в Java сериализуемые классы должны реализовывать интерфейс [Serializable][1]; 
в Python для сериализации используется модуль [pickle][2], входящий в стандартную библиотеку. 
Как правило, инструменты сериализации задают механизм сохранения данных по умолчанию, который предоставляет широкие возможности 
(например, сохранение объектов, на которые есть ссылки) и не требует внесения изменений в сериализуемые классы. 
Код, касающийся логики сериализации, требуется только тогда, когда поведение объекта при сериализации или восстановлении 
из постоянной памяти отличается от обычного.

Текстовые форматы сериализации используются в основном при передаче данных:

  * XML — пожалуй, наиболее развитый стандарт сериализации, предоставляющий широкие возможности для работы с данными, 
    например, проверку соответствия данных [схеме][3] или [преобразование документа][4]. Средства для работы с XML 
    присутствуют практически в каждом языке программирования.
  * JSON — более легковесный стандарт сериализации, используемый из-за меньшей громоздкости по сравнению с XML. 
    Помимо веб-приложений, JSON используется в документно-ориентированных базах данных, таких как [MongoDB][5].

Другой способ постоянного хранения данных — использование объектно-реляционных отображений, которые позволяют 
наладить двусторонний канал связи между реляционной БД и классами / объектами в ООП. 
Это значительно упрощает программирование по сравнению с использованием низкоуровневых средств доступа к базам данных 
и сокращает время на разработку. Современные ORM-системы позволяют в значительной мере избавиться от рутинных действий с СУБД; 
например, они позволяют автоматически создавать и обновлять структуру таблиц, соответствующих отдельным классам. 
ORM используются в MVC-платформах, где используются для создания моделей, 
а также в enterprise-приложениях (например, [Java Persistence API][6]).

[1]: http://docs.oracle.com/javase/8/docs/api/java/io/Serializable.html
[2]: https://docs.python.org/2/library/pickle.html
[3]: http://en.wikipedia.org/wiki/XML_schema
[4]: http://en.wikipedia.org/wiki/XSLT
[5]: https://www.mongodb.org/
[6]: http://docs.oracle.com/javaee/7/tutorial/persistence-intro001.htm
