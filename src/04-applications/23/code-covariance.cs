// $Стандартный интерфейс для перечислимых объектов.$
interface IEnumerable<out T> { /* ... */ }
// $Объект, перечисляющий круги — частный случай объекта,$
// $перечисляющего фигуры: IEnumerable<Circle> is IEnumerable<Shape>.$
