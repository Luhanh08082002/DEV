#pragma once
#ifndef MAIN_NV_OBJECT_H_

#define MAIN_NV_OBJECT_H_
#include <vector>
#include "CommonFunc.h"
#include "baseObject.h"
#include "BulletObject.h"


#define GRAVITY_SPEED 0.8
#define MAX_FALL_SPEED 10
#define PLAYER_SPEED 8
#define PLAYER_JUMP_VAL 18

class Main_nv_Object : public BaseObject
{
public:
	Main_nv_Object();
	~Main_nv_Object();

	enum WalkType
	{
		WALK_NONE = 0,
		WALK_RIGHT = 1,
		WALK_LEFT = 2,
	};

	bool LoadImg(std::string path, SDL_Renderer* screen);
	void Show(SDL_Renderer* des);
	void HandeInputAction(SDL_Event events, SDL_Renderer* screen);
	void set_clips();


	void DoPlayer(Map& map_data);
	void CheckToMap(Map& map_data);

	void SetMapXY(const int map_x, const int map_y) { map_x_ = map_x; map_y_ = map_y; };

	void CenterEntityOnMap(Map& map_data);

	void UpdateImagePlayer(SDL_Renderer* des);
	

	void set_bullet_list(std::vector<BulletObject*> bullet_list)
	{
		p_bullet_list_ = bullet_list;
	}
	std::vector<BulletObject*> get_bullet_list() const { return p_bullet_list_; }
	void HandleBullet(SDL_Renderer* des);

	void IncreseMoney();
private:

	int money_count;
	std::vector<BulletObject*> p_bullet_list_;
	float x_val_;
	float y_val_;

	float x_pos_;
	float y_pos_;

	int width_frame_;
	int height_frame_;

	SDL_Rect frame_clip_[8];
	Input input_type_; //luu trang thai nv
	int frame_; //luu trang thai cua frame
	int status_; // luu trang thai di chuyen trai /phai

	bool on_ground_;
	int map_x_;
	int map_y_;

	int come_back_time_;
};



#endif // !MAIN_NV_OBJECT_H_
