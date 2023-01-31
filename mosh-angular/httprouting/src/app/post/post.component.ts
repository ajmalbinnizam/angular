import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { of } from 'rxjs';
@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
// - http.get(url:string, options?:RequestOptionsArgs) : Observable<Response> returns an observable
// - observable has method called .subscribe()
// - 3 ways to use this method
// - subscribe(next?:(value:Response) => void,
// 			error?:(error:any) => void,complete?: () => void): Subscription
// - most of the time we won't want to use raw response obj, instead want to convert to json

  export class PostComponent {
    posts;
    constructor(httpClient: HttpClient) { 
      httpClient.get('http://jsonplaceholder.typicode.com/posts')
      .subscribe(response => {
        this.posts = response;
      });
    }
  }


