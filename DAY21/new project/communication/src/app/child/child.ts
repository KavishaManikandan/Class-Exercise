import { Component, EventEmitter, input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.html',
  styleUrl: './child.css'
})
export class Child {

// @Input() userData!: { name: string ; age: number};
//   @Input() value!: number;

userData=input();
  value=input();

  @Output() clickS =new EventEmitter<void>();
@Output() Come = new EventEmitter();


clicked(){
    this.clickS.emit();
  }
value1(){
  this.Come.emit();
}
}
