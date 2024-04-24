import { Injectable } from '@angular/core';
import { AddPostRequest } from '../models/add-post-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Post } from '../models/post.model';
import { environment } from '../../../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  constructor(private http: HttpClient) { }

  addPost(model: AddPostRequest): Observable<void>{
    return this.http.post<void>(`${environment.apiBaseUrl}/api/post`, model)
  }

  getAllPosts(): Observable<Post[]>{
    return this.http.get<Post[]>(`${environment.apiBaseUrl}/api/post`);
  }
}
