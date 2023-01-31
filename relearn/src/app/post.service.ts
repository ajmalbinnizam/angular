import { Post } from "./post.model";
import { HttpClient, HttpEventType, HttpHeaders, HttpParams} from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map, catchError, tap } from "rxjs/operators";
import { Subject, throwError } from "rxjs";

@Injectable({ providedIn: "root" })
export class PostService {
  error = new Subject<string>();
  constructor(private http: HttpClient) {}

  createPost(title: string, content: string) {
    let postData: Post = { title: title, content: content };
    this.http
      .post<{ name: string }>(
        "https://http-requests-369-default-rtdb.firebaseio.com/posts.json",
        postData,
        {
          observe: "response",
          // observe: 'events',
        }
      )
      .subscribe(
        (response) => console.log(response),
        (error) => this.error.next(error.message)
      );
  }

  fetchGet() {
    // pipe funnel the observable data through mutliple operator through subscribe
    // '{"-N5l4NR-KN73M6FhVIXZ":{"content":"sdfgdf","title":"sfgsdfs"},"-N5l4S2eE9UJrg3mu_cx":{"content":"sdfgdf","title":"sfgsdfs"}}'
    let searchParams = new HttpParams();
    searchParams = searchParams.append("pretty", "print");
    searchParams = searchParams.append("new", "serachParams"); //?pretty=print&new=serachParams
    return this.http
      .get<{ [key: string]: Post }>(
        "https://http-requests-369-default-rtdb.firebaseio.com/posts.json",
        {
          headers: new HttpHeaders({ custm: "hello this is a header" }),
          params: new HttpParams().set("print", "pretty"), //?pretty=print&new=serachParams
          // params: searchParams
        }
      )
      .pipe(
        map((responseData) => {
          let postArray: Post[] = [];
          for (let key in responseData) {
            if (responseData.hasOwnProperty(key))
              postArray.push({ ...responseData[key], id: key });
            // console.log(responseData[key]["content"])
          }
          return postArray;
        })
        // , catchError((error) => {
        //     return throwError(error.message)
        // })
      );
  }
  deletePost() {
    return this.http
      .delete(
        "https://http-requests-369-default-rtdb.firebaseio.com/posts.json",
        {
          observe: "events",
          responseType: "text",
        }
      )
      .pipe(
        tap((event) => {
          console.log(event);
          if (event.type === HttpEventType.Sent) {
            console.log("sent(0)", event.type);
          } else if (event.type === HttpEventType.Response) {
            console.log("response(4)", event.type);
          }
        })
      );
  }
}
