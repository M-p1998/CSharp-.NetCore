import { Component, OnInit } from '@angular/core';
import { PostService } from '../services/post.service';
import { Post } from '../models/post.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrl: './post-list.component.css'
})
export class PostListComponent implements OnInit{

  // posts?: Post[];
  posts$?: Observable<Post[]>;
    constructor(private postService: PostService){
      
    }

  ngOnInit(): void {
    this.posts$ = this.postService.getAllPosts();

      // .subscribe({
      //   next: (response)=>{
      //     this.posts = response;
      //   }
      // });
  
  }

}
