import { Component } from '@angular/core';
import { Baby } from '../baby/baby';

@Component({
  selector: 'app-mother',
  imports: [Baby],
  templateUrl: './mother.html',
  styleUrl: './mother.css'
})
export class Mother {
  user= {
    student : "kavisha",
    dob : "4/4/2005",

  };
demo(){
  console.log("hi,hello");

}
}
