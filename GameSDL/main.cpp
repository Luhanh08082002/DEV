#include"stdafx.h"
#include "CommonFunc.h"
#include "baseObject.h"
#include "game_map.h"
#include "Main_nv_Object.h";
#include "ImpTimer.h"
#include "TheatsObject.h"

BaseObject g_background;

bool InitData()
{
	bool success = true;
	int ret = SDL_Init(SDL_INIT_VIDEO);
	if (ret < 0) 
		return false;

	SDL_SetHint(SDL_HINT_RENDER_SCALE_QUALITY, "1");
	g_windows = SDL_CreateWindow("Game Cpp SDl 2.0 - Blog : ", 
									SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED,
		SCREEN_WIDTH,SCREEN_HEIGHT, SDL_WINDOW_SHOWN);

	if (g_windows == NULL)
	{
		success = false;
	}
	else
	{
		g_screen = SDL_CreateRenderer(g_windows, -1, SDL_RENDERER_ACCELERATED);
		if (g_screen == NULL)
		{
			success = true;
		}
		else
		{
			SDL_SetRenderDrawColor(g_screen, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR);
			int imglags = IMG_INIT_PNG;
			if (!(IMG_Init(imglags) && imglags))
				success = false;
		}
	}
	
	return success;
	
}

bool Loadbackground() {
	bool ret = g_background.LoadImg("background_img.jpg", g_screen);
	if (ret == false)
		return false;
	return true;
}

void close()
{
	g_background.Free();
	SDL_DestroyRenderer(g_screen);
	g_screen = NULL;
	SDL_DestroyWindow(g_windows);
	g_windows = NULL;
	IMG_Quit();
	SDL_Quit();
}

std::vector<ThreatsObject*> MakeThreadList()
{
	std::vector<ThreatsObject*> list_threats;

	ThreatsObject* dynamic_threats = new ThreatsObject[20];
	for (int i = 0; i < 20; i++)
	{
		ThreatsObject* p_threat = (dynamic_threats + i);
		if (p_threat != NULL)
		{
			p_threat->LoadImg("img//threat_left.png", g_screen);
			p_threat->set_clips();
			p_threat->set_type_move(ThreatsObject::MOVE_IN_SPACE_THREAT);
			p_threat->set_x_pos(500 + i * 500);
			p_threat->set_y_pos(200);

			int pos1 = p_threat->get_x_pos() - 60;
			int pos2 = p_threat->get_y_pos() + 60;
			p_threat->SetAnimationPos(pos1, pos2);
			p_threat->set_input_left(1);
			list_threats.push_back(p_threat);
		}
	}


	ThreatsObject* threats_objs = new ThreatsObject[20];

	for (int i = 0; i < 20; i++)
	{
		ThreatsObject* p_threat = (threats_objs + i);
		if (p_threat != NULL) {
			p_threat->LoadImg("img//threat_level.png", g_screen);
			p_threat->set_clips();
			p_threat->set_x_pos(700 + i*1200);
			p_threat->set_y_pos(250);
			p_threat->set_type_move(ThreatsObject::STATIC_THREAT);
			p_threat->set_input_left(0);
			list_threats.push_back(p_threat);
		}
	}

	return list_threats;
}

int main(int argc, char* argv[])
{
	ImpTimer fps_timer;

	if (InitData() == false)
		return -1;
	if (Loadbackground() == false)
		return -1;

	char dat[] = "map/map01.dat";
	
	GameMap game_map;
	game_map.LoadMap(dat);
	game_map.LoadTiles(g_screen);


	Main_nv_Object p_player;
	p_player.LoadImg("img//player_right.png", g_screen);
	p_player.set_clips();

	std::vector<ThreatsObject*> threats_list = MakeThreadList();


	bool is_quit = false;
	while (!is_quit)
	{
		fps_timer.start();
		while (SDL_PollEvent(&g_event) != 0)
		{
			if (g_event.type == SDL_QUIT)
			{
				is_quit = true;
			}

			p_player.HandeInputAction(g_event, g_screen);
		}

		SDL_SetRenderDrawColor(g_screen, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR, RENDER_DRAM_COLOR);
		SDL_RenderClear(g_screen);

		g_background.Render(g_screen, NULL);
		
		Map map_data = game_map.getMap();

		p_player.HandleBullet(g_screen);
		p_player.SetMapXY(map_data.start_x_, map_data.start_y_);
		p_player.DoPlayer(map_data);
		p_player.Show(g_screen);
	
		game_map.SetMap(map_data);
		game_map.DrawMap(g_screen);

		for (int i = 0; i < threats_list.size(); i++)
		{
			ThreatsObject* p_threat = threats_list.at(i);
			if (p_threat != NULL)
			{
				p_threat->SetMapXY(map_data.start_x_, map_data.start_y_);
				p_threat->ImpMovetype(g_screen);
				p_threat->DoPlayer(map_data);
				p_threat->Show(g_screen);
			}
		}



		SDL_RenderPresent(g_screen);


		int real_imp_time = fps_timer.get_tick();
		int time_one_frame = 1000 / FRAME_PER_SECOND; //ms

		if (real_imp_time < time_one_frame)
		{
			int delay_time = time_one_frame - real_imp_time;
			if (delay_time >= 0)
				SDL_Delay(delay_time);
		}
	}


	close();
	return 0;
}

