import { CommonModule } from '@angular/common';
import { Component,OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';


@Component({
  selector: 'app-user-form',
  imports: [FormsModule,ReactiveFormsModule,CommonModule],
  templateUrl: './user-form.html',
  styleUrl: './user-form.css'
})
export class UserForm {
    userForm!: FormGroup;

    countries=['delhi','mumbai'];
    ngOnInit(){
      this.userForm = new FormGroup({
        name: new FormControl('',[Validators.required, Validators.minLength(3)]),
        age: new FormControl('', [Validators.required]),
        email:new FormControl('',[Validators.required]),
        password: new FormControl('',[Validators.required])
      })
    }

    onSubmit(){
      console.log(this.userForm)
    }




}
