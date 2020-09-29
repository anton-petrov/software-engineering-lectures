# Лекции по программной инженерии

[![Build Status](https://travis-ci.org/slowli/software-engineering-lectures.svg?branch=master)](https://travis-ci.org/slowli/software-engineering-lectures)

Набор презентаций для лекций по программной инженерии.
(c) 2014, 2015, 2017, Алексей Островский

Текст лекций доступен под лицензией [CC BY-SA 4.0 International](LICENSE).
Выдержки кода и используемые программы доступны под лицензией [Apache 2.0](LICENSE-CODE).

## Содержимое репозитория

Репозиторий включает в себя следующие папки и файлы:
  * **src/**  
    Исходные TeX-файлы для презентаций лекций. Там же расположены краткие изложения
    лекций (файлы `README.md`).
  * **common/**  
    Общие для всех лекций исходные TeX-файлы.
  * **gh-pages/**  
    Файлы для построения [сайта GitHub Pages с лекциями](https://slowli.github.io/software-engineering-lectures).
  * **out/**  
    Папка для результатов компиляции, т.е. pdf-файлов лекций.
  * **tmp/**  
    Папка для промежуточных файлов. В частности, там хранятся логи компиляции.

## Построение

Построение осуществляется при помощи утилиты make. Необходим XeLaTeX
(работоспособность проверялась на TeXLive 2013 и 2015). Установить всё необходимое для LaTeX можно при помощи команды
```sh
sudo apt-get install --no-install-recommends texlive \
  texlive-latex-extra texlive-xetex \
  latex-beamer ghostscript \
  fonts-lmodern fonts-droid fonts-noto
```

### Цели построения презентаций

Все цели вызываются с командой `make`, например, `make all-beamer`.

  * **i-a4**, где i=01,02,03,...  
    Компилирует одну презентацию. В результате образуется файл out/*i*-*название лекции*.pdf -
    презентация на листе формата A4.
  * **i-beamer**, где i=01,02,03,...  
    Компилирует одну презентацию. В результате образуется файл out/*i*-*название лекции*-beamer.pdf -
    презентация стандартного для проектора разрешения.
  * **i**  
    Эквивалентно двум предыдущим командам.
  * **all-a4**  
    Компилирует все презентации на листах A4.
  * **all-beamer**  
    Компилирует все презентации для проектора.
  * **all**  
    all-a4 + all-beamer.
  * **clean**  
    Удаляет промежуточные файлы компиляции.
  * **uninstall**  
    Удаляет промежуточные файлы компиляции и pdf-файлы презентаций.

### Цели построения сайта GitHub Pages

Помимо предыдущих зависимостей, для локального тестирования сайта GitHub Pages
нужно установить генератор сайтов Jekyll. Руководство есть на сайте [Pages](https://pages.github.com/).

  * **gh-pages**  
    Создает локальную версию веб-сайта.
  * **gh-serve**  
    Создает локальную версию веб-сайта и запускает демо веб-север, доступный
    по адресу http://localhost:4000/.
  * **gh-push-local**  
    Пушит *исходные* материалы для построения веб-сайта в ветвь локального репозитория `gh-pages`;
    при этом используется опция `git push --force`, так что все предыдущие изменения
    в этой ветке стираются. Фактически, пушатся те данные, которые нужны для построения веб-сайта
    средствами GitHub Pages.
  * **clean-gh**  
    Удаляет артефакты построения локального веб-сайта в папке **gh-pages**.

## Конфигурация

Основной параметр настройки — шрифты, используемые в презентациях. Для изменения набора
шрифтов следует переопределить переменную окружения `LECTURE_FONTS`. Команды построения
берут шрифты из файла `common/fonts.$(LECTURE_FONTS).def`. По умолчанию доступны три
настройки:
  * `droid` использует шрифты семейства Droid (Sans, Serif и Sans Mono).
    Не лучший вариант, т.к. в Droid Sans нет курсивного начертания.
  * `noto` использует шрифты семейства Noto (Sans, Serif и Mono). Noto Mono нет
    в дистрибутиве Ubuntu 14.04 (но есть, скажем, в 16.04).
  * `noto+droid` использует Noto Sans, Noto Serif и Droid Sans Mono.

Для GitHub Pages доступны опции:

  * `GH_PAGES_NOFILES`. Если эта переменная окружения определена при вызове `make`,
    построение презентаций при генерации веб-сайта
    пропускается. Полезно, например, для отладки дизайна.
  * `GH_PAGES_HOST`. Устанавливает хост для Jekyll. Значение по умолчанию - `127.0.0.1`.

Пример использования:
```sh
make GH_PAGES_NOFILES=1 GH_PAGES_HOST=10.0.2.15 gh-serve
```

## Непрерывная интеграция

Репозиторий использует сервис непрерывной интеграции [Travis](https://travis-ci.org/)
для тестирования билдов. К сожалению, в автоматическом режиме сложно проверять pdf-файлы
презентаций, так что тесты достаточно примитивные:

  * Для каждого файла лекции проверяется, что TeX-компилятор не ругается на
    переполненные или недозаполенные боксы.
  * Для сайта GitHub Pages валидируется HTML и проверяется, нет ли битых ссылок.
