import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'cm-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  @Input() showHeader: boolean = true;

  constructor() { }

  ngOnInit() {
  }

}
