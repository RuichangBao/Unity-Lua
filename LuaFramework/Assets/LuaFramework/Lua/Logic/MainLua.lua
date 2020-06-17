local aaa=require("Logic/TestLua")

MainLua={};
local this=MainLua;

function MainLua.Prints(str)
	print("MainLuaAAAAAAAAAAAAAAAA Prints"..str);
	aaa.PrintHello("fdasfdsfasd");
end