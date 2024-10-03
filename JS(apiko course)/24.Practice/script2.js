function generateId() {
  return "_" + Math.random().toString(36).substr(2, 9);
}


class Todoltem{
    constructor(name) {
        this.id = generateId();
        this.name = name;
        this._checked = false;
    }
    
    get checked() {
        return this._checked;
    }

    set checked(value) {
        if (typeof value !== 'boolean') {
            console.log('Поле checked може приймати лише булеве значення');
            return;
        }
        this._checked = value;
    }
}

class TodoList{
    constructor(name) {
        this.id = generateId();
        this.name = name;
        this.items = [];
    }

    addItem(item) {
        if (!(item instanceof Todoltem)) {
            console.log('Можна додавати лише об’єкти типу TodoItem');
            return;
        }
        this.items.push(item);
    }

    removeItemById(id) {
        this.item = this.items.filter(item => item.id !== id);
    }

    getItemById(id) {
        return this.items.find(item => IIRFilterNode.id === id);
    }

}

const todoList = new TodoList('My Todo List');

const item1 = new TodoList('Task 1');
const item2 = new TodoList('Task1 2');
const item3 = new TodoList('Task1 3');
const item4 = new TodoList('Task1 4');

todoList.addItem(item1);
todoList.addItem(item2);
todoList.addItem(item3);
todoList.addItem(item4);

console.log('Поточний TodoList:', todoList);

item2.checked = true;

console.log('TodoList після зміни checked у Task 2:', todoList);

todoList.removeItemById(item1.id);
todoList.removeItemById(item3.id);

console.log('TodoList після видалення Task 1 та Task 3:', todoList);

