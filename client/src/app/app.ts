import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  // protected readonly title = signal('client');

  private http = inject(HttpClient);
  protected title = 'Dating App';
  protected members: any[] = []; //any will turn off typescript for users property
  protected fixedAssets: any[] = [];

  //old
  // constructor(private http: HttpClient){}

    ngOnInit(): void {
      // throw new Error('Method not implemented');
      //members
      this.http.get('https://localhost:5001/api/users').subscribe({
        next: response => this.members = response as any[],
        error: error => console.log(error),
        complete: () => console.log('Completed the http request')
      });

      //fixedassets
       this.http.get('https://localhost:5001/api/fixedassets').subscribe({
        next: response => this.fixedAssets = response as any[],
        error: error => console.log(error),
        complete: () => console.log('Completed  fixed assets request')
      });
  }
}
