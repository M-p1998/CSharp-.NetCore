import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PostListComponent } from './features/post/post-list/post-list.component';
import { AddPostComponent } from './features/post/add-post/add-post.component';

const routes: Routes = [
  {
    path: "posts",
    component: PostListComponent
  },
  {
    path: "post/add",
    component: AddPostComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
