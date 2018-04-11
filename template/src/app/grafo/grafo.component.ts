import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'cm-grafo',
  templateUrl: './grafo.component.html',
  styleUrls: ['./grafo.component.css']
})
export class GrafoComponent implements OnInit {

  isUploading: boolean = false;

  constructor() { }

  ngOnInit() {
  }

  public uploadFile(): void {
    this.isUploading = true;
  }

}
