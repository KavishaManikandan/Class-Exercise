import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-baby',
  imports: [],
  templateUrl: './baby.html',
  styleUrl: './baby.css'
})
export class Baby {
@Input() ID!: {student:string ; dob: string };
@Output() click =new EventEmitter();

value(){
  this.click.emit;
}
}
