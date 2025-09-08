import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Child } from '../child/child';


@Component({
  selector: 'app-parent',
  imports: [Child,CommonModule],
  templateUrl: './parent.html',
  styleUrl: './parent.css'
})
export class Parent {
user = {
  name: 'kavi',
  age: 20,
};
input:number=22500;


@Input() userId! : string 
@Input() id! : number
  action: any;

sample(){
  window.alert('Hiii')
}
@Output() submit = new EventEmitter() ;

clicked(){
    this.submit.emit();
  }
id1(){
  window.alert('comein')
}
}
