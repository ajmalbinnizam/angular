import { PostService } from './post.service';
import { ActivatedRoute } from '@angular/router';
import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { map } from 'rxjs/operators';
import { Post } from './post.model';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  @ViewChild('postForm', { static: false }) postForm;
  private erroSub: Subscription;
  loadedPosts: Post[] = [];
  isFetching = false;
  error = null;
  constructor(private http: HttpClient, private postService: PostService) { }

  ngOnInit() {
    this.erroSub = this.postService.error.subscribe((errorMessage) => {
      this.error = errorMessage;
    })
    this.onFetchPosts();
  }

  onCreatePost(postData: Post) {
    // Send Http request
    this.postForm;
    this.postService.createPost(postData.title, postData.content);
  }

  onFetchPosts() {
    // Send Http request
    this.isFetching = true;
    this.postService.fetchGet().subscribe(response => {
      this.loadedPosts = response
      this.isFetching = false;
      // console.log(response)
      // console.log(response[0].content)
    }, error => {
      this.isFetching = false;
      this.error = error;
    }
    )
  }

  onClearPosts() {
    // Send Http request
    this.postService.deletePost().subscribe(() => {
      this.loadedPosts = []
    });
  }

  onHandleError() {
    this.error = null;
  }
  ngOnDestroy(): void {
    this.erroSub.unsubscribe(); 
  }

}
