Приклади проєктів для вимірювання розміру коду різних примітивних програмних операцій.
==========================

Мета цього експерименту — виміряти, скільки «важать» у байткоді примітивні програмні концепції.
Я намагаюся писати більш-менш ідіоматичний код, а не той, який люди використовують при максимальній оптимізації розміру.
Назвімо це типовим кодом з низьким рівнем зусиль.

Зараз у мене в коді лише низькорівневі операції. Але насправді я хочу вимірювати різні рівні абстракції.
Наприклад, скільки займає код для створення ZIP-архіву, скільки потрібно для одного HTTP-запиту,
скільки коду потрібно, щоб створити порожнє вікно інтерфейсу, або кнопку тощо. Це може бути неоднозначно,
але якщо почати з простих речей і формулювати завдання точніше, то ми, ймовірно, зможемо зібрати достатньо цікавої інформації,
щоб зрозуміти, чому наше програмне забезпечення іноді займає сотні мегабайт,
і чому залежності в деяких мовах важать гігабайти — навіть для відносно простих застосунків.

Тоді можна буде дати більш конкретне пояснення, а не абстрактне «бо ми не дбаємо про залежності».
Це ж не дає ніяких практичних висновків, як на мене.

Якщо ви згодні допомогти з цим доволі рутинним процесом — надішліть, будь ласка, pull request.

[In English](./README.md)

# Як запустити
```
./measure.ps1
```

# Компоненти

- [PrintLine](./printline) Надрукувати рядок у консоль.
- [SumStrings](./sum_strings) Виконати конкатенацію двох рядків у мові
- [ParseFloat](./parse_float) Розібрати рядок із числом з плаваючою комою у тип float32.
- [StrReverse](./strreverse) Перевернути константний рядок
- [ToLower](./tolower) Перетворити рядок на нижній регістр з використанням параметрів локалі за замовчуванням у мові.
- [StrEmpty](./strempty) Перевірити чи рядок пустий.
- [ArrayInit](./arrayinit) Ініціалізувати масив 100 байт і надрукувати усі 100 значень.
- [CmdLineArgs](./cmdlineargs) Надрукувати усі передані аргументи командного рядку
- [CmdLineArgs2](./cmdlineargs2) Розібрати 4 аргументи командного рядка та надрукувати їх.
- [ReadFile](./readfile) Прочитати весь файл в консоль
- [WriteFile](./writefile) Записує зміст строки в файл
- [CreateFile](./createfile) Створює пустий файл із заданою назвою.
- [CreateDir](./createdir) Створює пусту діректорію із заданою назвою.
- [CreateDir2](./createdir2) Створює пусту діректорію із заданою назвою і усі шляхи по дорозі.
- [ZipFile](./archivefile) Архівує рядок у один файл запакований в ZIP файл.
- [Win32Window](./win32_window) Створити пусте Win32 вікно.
- [Win32Button](./win32_button) Створити Win32 вікно із однією кнопкою.
- [RandInt](./randint) Сгенерувати псевдовипадкове число
- [RegexMatch](./regex_match) Перевірити чи співпадає строка по шаблону із регулярного виразу

# Вартість абстракцій
- [ProxyCallBaseline](./proxycall_baseline) 10 функцій із одним аргументом. Кожна із них викликається
- [ProxyCall](./proxycall) 10 огорточних функцій які передають один константний 10 іншіх функцій заданих так само як і в ProxyCallBaseline. Оцінка вартості абстракцій.

# Результати

Нульові або від’ємні значення означають, що я не можу надійно виміряти або оцінити цей розмір.
Очевидно, ця функціональність має ненульовий розмір.
Ймовірно, я переоцінив розмір рантайму, мінімальної функції main, і коду, який вже був виділений для цього.


## C language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 10,752 |
| PrintLine  | 0 |
| SumStrings | 1,024 |
| ParseFloat | 0 |
| StrReverse | 0 |
| ToLower    | 512 |
| StrEmpty   | 512 |
| ArrayInit  | 0 |
| CmdLineArgs| 0 |
| CmdLineArgs2| 4,608 |
| ReadFile   | 512 |
| WriteFile  | 0 |
| CreateFile | 0 |
| CreateDir  | 0 |
| CreateDir2 | 1,536 |
| ZipFile    | 190,464 |
| Win32Window| 1,536 |
| Win32Button| 0 |
| ProxyCallBaseline| 512 |
| ProxyCall  | 0 |
| RandInt    | 0 |
| RegexMatch | 311,808 |

## Rust language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 125,440 |
| PrintLine  | 12,800 |
| SumStrings | 512 |
| ParseFloat | 17,408 |
| StrReverse | 1,024 |
| ToLower    | 17,408 |
| StrEmpty   | 0 |
| ArrayInit  | 512 |
| CmdLineArgs| 7,168 |
| CmdLineArgs2| 540,160 |
| ReadFile   | 13,312 |
| WriteFile  | 12,288 |
| CreateFile | 8,192 |
| CreateDir  | 16,896 |
| CreateDir2 | 16,896 |
| ZipFile    | 927,744 |
| Win32Window| 9,216 |
| Win32Button| 512 |
| ProxyCallBaseline| 1,024 |
| ProxyCall  | 0 |
| RandInt    | 13,312 |
| RegexMatch | 1,626,624 |

## C# NativeAOT language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 1,044,480 |
| PrintLine  | 60,928 |
| SumStrings | 512 |
| ParseFloat | 26,112 |
| StrReverse | 14,336 |
| ToLower    | 2,560 |
| StrEmpty   | 0 |
| ArrayInit  | 3,584 |
| CmdLineArgs| 512 |
| CmdLineArgs2| 2,309,120 |
| ReadFile   | 122,880 |
| WriteFile  | 106,496 |
| CreateFile | 104,960 |
| CreateDir  | 13,824 |
| CreateDir2 | 13,824 |
| ZipFile    | 907,264 |
| Win32Window| 113,152 |
| Win32Button| 1,024 |
| ProxyCallBaseline| 1,536 |
| ProxyCall  | -62,464 |
| RandInt    | 0 |
| RegexMatch | 437,248 |

## Go language basics
| Component    | Size (B) |
| ------------ | -----: |
| Runtime    | 863,744 |
| PrintLine  | 406,528 |
| SumStrings | 0 |
| ParseFloat | 18,432 |
| StrReverse | 2,560 |
| ToLower    | 13,312 |
| StrEmpty   | -512 |
| ArrayInit  | 512 |
| CmdLineArgs| 0 |
| CmdLineArgs2| 101,888 |
| ReadFile   | 107,520 |
| WriteFile  | 7,680 |
| CreateFile | 8,192 |
| CreateDir  | 4,096 |
| CreateDir2 | 107,008 |
| ZipFile    | 331,776 |
| Win32Window| 440,320 |
| Win32Button| 1,024 |
| ProxyCallBaseline| 4,096 |
| ProxyCall  | 1,024 |
| RandInt    | 84,480 |
| RegexMatch | 273,920 |