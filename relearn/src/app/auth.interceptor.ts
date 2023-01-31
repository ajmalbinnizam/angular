import { tap } from "rxjs/operators"
import {
  HttpEvent,
  HttpEventType,
  HttpHandler,
  HttpInterceptor,
  HttpRequest
} from "@angular/common/http"
import { Injectable } from "@angular/core"
import { Observable } from "rxjs"

export class InterceptorService implements HttpInterceptor {
  injector: any

  constructor() {}
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    console.log("request on its way")
    // const url = req.clone({body: req.headers.append('new', 'serachParams')})
    const modifiedRequest = this.handleBody(req)
    return next.handle(modifiedRequest).pipe(
      tap(event => {
        if (event.type == HttpEventType.Response) {
          console.log("response arrived")
          console.log(event.body)
        }
      })
    )
    // return next.handle(req);
  }
  handleBody(req: HttpRequest<any>) {
    if (req.method.toLowerCase() == "post") {
      req = req.clone({
        headers: req.headers.append("key", "values pairs of headers") //gotchaa never make space in key
        // body: {...req.body, hello: 'world' }
      })
    }
    return req
  }

  // inter(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
  //   console.log("Intercepted!", req);
  //   const reqCloned = this.handleBodyIn( req, localStorage.getItem("random_key"), "random_key_added");
  //   const copiedReq = reqCloned;
  //   return next.handle(copiedReq);
  // }
  // handleBodyIn(req: HttpRequest<any>, tokenToAdd, tokenName) {
  //   if (req.method.toLowerCase() === "post") {
  //     if (req.body instanceof FormData) {
  //       req = req.clone({
  //         body: req.body.append(tokenName, tokenToAdd),
  //       });
  //     } else {
  //       const foo = {};
  //       foo[tokenName] = tokenToAdd;
  //       req = req.clone({
  //         body: { ...req.body, ...foo },
  //       });
  //     }
  //   }
  //   if (req.method.toLowerCase() === "get") {
  //     req = req.clone({
  //       params: req.params.set(tokenName, tokenName),
  //     });
  //   }
  //   return req;
  // }
}
