import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Parent } from './parent/parent';
import { Mother } from './mother/mother';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Parent,Mother],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('communication');
  User :string="class"
  Demo:number=25


  id(){
  window.alert('welcome')
}
  }

